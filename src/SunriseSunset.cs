﻿// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.

using SunCalcNet.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace WinDynamicDesktop
{
    public enum PolarPeriod { None, PolarDay, PolarNight };

    public class SolarData
    {
        public PolarPeriod polarPeriod = PolarPeriod.None;

        public DateTimeTZ sunriseTime { get; set; } = DateTimeTZ.Local.Now.ConvertTime(JsonConfig.settings.timezone);

        public DateTimeTZ sunsetTime { get; set; } = DateTimeTZ.Local.Now.ConvertTime(JsonConfig.settings.timezone);

        public DateTimeTZ[] solarTimes { get; set; }
    }

    internal class SunriseSunsetService
    {
        private static readonly Func<string, string> _ = Localization.GetTranslation;

        private static SolarData GetUserProvidedSolarData(DateTime date)
        {
            SolarData data = new SolarData();
            data.sunriseTime = date.Date + UpdateHandler.SafeParse(JsonConfig.settings.sunriseTime).TimeOfDay;
            data.sunsetTime = date.Date + UpdateHandler.SafeParse(JsonConfig.settings.sunsetTime).TimeOfDay;

            int halfSunriseSunsetDuration = JsonConfig.settings.sunriseSunsetDuration * 30;
            data.solarTimes = new DateTimeTZ[4]
            {
                data.sunriseTime.AddSeconds(-halfSunriseSunsetDuration),
                data.sunriseTime.AddSeconds(halfSunriseSunsetDuration),
                data.sunsetTime.AddSeconds(-halfSunriseSunsetDuration),
                data.sunsetTime.AddSeconds(halfSunriseSunsetDuration)
            };

            return data;
        }

        private static List<SunPhase> GetSunPhases(DateTimeTZ date, double latitude, double longitude)
        {
            return SunCalcNet.SunCalc.GetSunPhases(date.AddHours(12).ToUniversalTime(), latitude, longitude).ToList();
        }

        private static DateTimeTZ GetSolarTime(List<SunPhase> sunPhases, SunPhaseName desiredPhase)
        {
            return new DateTimeTZ(TimeZoneInfo.Utc, sunPhases.Single(sunPhase => sunPhase.Name.Value == desiredPhase.Value).PhaseTime.ToUniversalTime()).ConvertTime(JsonConfig.settings.timezone);
        }

        public static SolarData GetSolarData(DateTimeTZ date)
        {
            if (JsonConfig.settings.dontUseLocation)
            {
                return GetUserProvidedSolarData(date);
            }

            double latitude = double.Parse(JsonConfig.settings.latitude, CultureInfo.InvariantCulture);
            double longitude = double.Parse(JsonConfig.settings.longitude, CultureInfo.InvariantCulture);
            var sunPhases = GetSunPhases(date, latitude, longitude);
            SolarData data = new SolarData();

            try
            {
                data.sunriseTime = GetSolarTime(sunPhases, SunPhaseName.Sunrise).ConvertTime(JsonConfig.settings.timezone);
                data.sunsetTime = GetSolarTime(sunPhases, SunPhaseName.Sunset).ConvertTime(JsonConfig.settings.timezone);
                data.solarTimes = new DateTimeTZ[4]
                {
                    GetSolarTime(sunPhases, SunPhaseName.Dawn),
                    GetSolarTime(sunPhases, SunPhaseName.GoldenHourEnd),
                    GetSolarTime(sunPhases, SunPhaseName.GoldenHour),
                    GetSolarTime(sunPhases, SunPhaseName.Dusk)
                };
            }
            catch (InvalidOperationException)  // Handle polar day/night
            {
                DateTimeTZ solarNoon = GetSolarTime(sunPhases, SunPhaseName.SolarNoon);
                double sunAltitude = SunCalcNet.SunCalc.GetSunPosition(solarNoon.ToUniversalTime(), latitude, longitude).Altitude;

                if (sunAltitude > 0)
                {
                    data.polarPeriod = PolarPeriod.PolarDay;
                }
                else
                {
                    data.polarPeriod = PolarPeriod.PolarNight;
                }
            }

            return data;
        }

        public static string GetSunriseSunsetString(SolarData solarData)
        {
            switch (solarData.polarPeriod)
            {
                case PolarPeriod.PolarDay:
                    return _("Sunrise/Sunset: Up all day");

                case PolarPeriod.PolarNight:
                    return _("Sunrise/Sunset: Down all day");

                default:
                    return string.Format(_("Sunrise: {0}, Sunset: {1}"), solarData.sunriseTime.ToShortTimeString(),
                        solarData.sunsetTime.ToShortTimeString());
            }
        }
    }
}