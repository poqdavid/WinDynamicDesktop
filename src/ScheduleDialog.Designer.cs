﻿namespace WinDynamicDesktop
{
    partial class ScheduleDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.locationLabel = new System.Windows.Forms.Label();
            this.locationBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.locationPermissionLabel = new System.Windows.Forms.Label();
            this.sunriseTimeLabel = new System.Windows.Forms.Label();
            this.sunsetTimeLabel = new System.Windows.Forms.Label();
            this.sunriseTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sunsetTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sunriseSunsetDurationLabel = new System.Windows.Forms.Label();
            this.grantPermissionButton = new System.Windows.Forms.Button();
            this.sunriseSunsetDurationBox = new System.Windows.Forms.NumericUpDown();
            this.checkPermissionButton = new System.Windows.Forms.Button();
            this.timezoneLabel = new System.Windows.Forms.Label();
            this.timezoneBox = new System.Windows.Forms.ComboBox();
            this.longitudeTextBox = new System.Windows.Forms.TextBox();
            this.latitudeTextBox = new System.Windows.Forms.TextBox();
            this.longitudeLabel = new System.Windows.Forms.Label();
            this.latitudeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sunriseSunsetDurationBox)).BeginInit();
            this.SuspendLayout();
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(27, 40);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(196, 13);
            this.locationLabel.TabIndex = 2;
            this.locationLabel.Text = "Enter your location (e.g., New York NY):";
            // 
            // locationBox
            // 
            this.locationBox.Location = new System.Drawing.Point(30, 56);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(293, 20);
            this.locationBox.TabIndex = 1;
            this.locationBox.TextChanged += new System.EventHandler(this.OnInputValueChanged);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(166, 365);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 12;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(248, 365);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 14);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(263, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Use location to determine sunrise and sunset times";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.OnInputValueChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(12, 92);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(256, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Use Windows location service to determine times";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.OnInputValueChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(12, 175);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(201, 17);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.Text = "Use specific sunrise and sunset times";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.OnInputValueChanged);
            // 
            // locationPermissionLabel
            // 
            this.locationPermissionLabel.AutoSize = true;
            this.locationPermissionLabel.Enabled = false;
            this.locationPermissionLabel.Location = new System.Drawing.Point(28, 118);
            this.locationPermissionLabel.Name = "locationPermissionLabel";
            this.locationPermissionLabel.Size = new System.Drawing.Size(146, 13);
            this.locationPermissionLabel.TabIndex = 7;
            this.locationPermissionLabel.Text = "Only available in Windows 10";
            // 
            // sunriseTimeLabel
            // 
            this.sunriseTimeLabel.AutoSize = true;
            this.sunriseTimeLabel.Enabled = false;
            this.sunriseTimeLabel.Location = new System.Drawing.Point(27, 202);
            this.sunriseTimeLabel.Name = "sunriseTimeLabel";
            this.sunriseTimeLabel.Size = new System.Drawing.Size(45, 13);
            this.sunriseTimeLabel.TabIndex = 8;
            this.sunriseTimeLabel.Text = "Sunrise:";
            // 
            // sunsetTimeLabel
            // 
            this.sunsetTimeLabel.AutoSize = true;
            this.sunsetTimeLabel.Enabled = false;
            this.sunsetTimeLabel.Location = new System.Drawing.Point(193, 201);
            this.sunsetTimeLabel.Name = "sunsetTimeLabel";
            this.sunsetTimeLabel.Size = new System.Drawing.Size(43, 13);
            this.sunsetTimeLabel.TabIndex = 10;
            this.sunsetTimeLabel.Text = "Sunset:";
            // 
            // sunriseTimePicker
            // 
            this.sunriseTimePicker.Enabled = false;
            this.sunriseTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.sunriseTimePicker.Location = new System.Drawing.Point(78, 198);
            this.sunriseTimePicker.Name = "sunriseTimePicker";
            this.sunriseTimePicker.ShowUpDown = true;
            this.sunriseTimePicker.Size = new System.Drawing.Size(94, 20);
            this.sunriseTimePicker.TabIndex = 6;
            this.sunriseTimePicker.Value = new System.DateTime(1970, 1, 1, 6, 0, 0, 0);
            this.sunriseTimePicker.ValueChanged += new System.EventHandler(this.OnInputValueChanged);
            // 
            // sunsetTimePicker
            // 
            this.sunsetTimePicker.Enabled = false;
            this.sunsetTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.sunsetTimePicker.Location = new System.Drawing.Point(242, 198);
            this.sunsetTimePicker.Name = "sunsetTimePicker";
            this.sunsetTimePicker.ShowUpDown = true;
            this.sunsetTimePicker.Size = new System.Drawing.Size(94, 20);
            this.sunsetTimePicker.TabIndex = 7;
            this.sunsetTimePicker.Value = new System.DateTime(1970, 1, 1, 18, 0, 0, 0);
            this.sunsetTimePicker.ValueChanged += new System.EventHandler(this.OnInputValueChanged);
            // 
            // sunriseSunsetDurationLabel
            // 
            this.sunriseSunsetDurationLabel.AutoSize = true;
            this.sunriseSunsetDurationLabel.Enabled = false;
            this.sunriseSunsetDurationLabel.Location = new System.Drawing.Point(26, 253);
            this.sunriseSunsetDurationLabel.Name = "sunriseSunsetDurationLabel";
            this.sunriseSunsetDurationLabel.Size = new System.Drawing.Size(176, 13);
            this.sunriseSunsetDurationLabel.TabIndex = 15;
            this.sunriseSunsetDurationLabel.Text = "Sunrise/Sunset Duration in minutes:";
            // 
            // grantPermissionButton
            // 
            this.grantPermissionButton.Enabled = false;
            this.grantPermissionButton.Location = new System.Drawing.Point(31, 139);
            this.grantPermissionButton.Name = "grantPermissionButton";
            this.grantPermissionButton.Size = new System.Drawing.Size(141, 23);
            this.grantPermissionButton.TabIndex = 3;
            this.grantPermissionButton.Text = "Grant Permission";
            this.grantPermissionButton.UseVisualStyleBackColor = true;
            this.grantPermissionButton.Click += new System.EventHandler(this.grantPermissionButton_Click);
            // 
            // sunriseSunsetDurationBox
            // 
            this.sunriseSunsetDurationBox.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.sunriseSunsetDurationBox.Location = new System.Drawing.Point(208, 250);
            this.sunriseSunsetDurationBox.Maximum = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.sunriseSunsetDurationBox.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.sunriseSunsetDurationBox.Name = "sunriseSunsetDurationBox";
            this.sunriseSunsetDurationBox.Size = new System.Drawing.Size(94, 20);
            this.sunriseSunsetDurationBox.TabIndex = 10;
            this.sunriseSunsetDurationBox.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // checkPermissionButton
            // 
            this.checkPermissionButton.Enabled = false;
            this.checkPermissionButton.Location = new System.Drawing.Point(182, 139);
            this.checkPermissionButton.Name = "checkPermissionButton";
            this.checkPermissionButton.Size = new System.Drawing.Size(141, 23);
            this.checkPermissionButton.TabIndex = 4;
            this.checkPermissionButton.Text = "Check for Permission";
            this.checkPermissionButton.UseVisualStyleBackColor = true;
            this.checkPermissionButton.Click += new System.EventHandler(this.checkPermissionButton_Click);
            // 
            // timezoneLabel
            // 
            this.timezoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.timezoneLabel.AutoSize = true;
            this.timezoneLabel.Location = new System.Drawing.Point(27, 298);
            this.timezoneLabel.Name = "timezoneLabel";
            this.timezoneLabel.Size = new System.Drawing.Size(136, 13);
            this.timezoneLabel.TabIndex = 20;
            this.timezoneLabel.Text = "Enter your timezone (e.g., ):";
            // 
            // timezoneBox
            // 
            this.timezoneBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timezoneBox.FormattingEnabled = true;
            this.timezoneBox.Location = new System.Drawing.Point(30, 314);
            this.timezoneBox.Name = "timezoneBox";
            this.timezoneBox.Size = new System.Drawing.Size(293, 21);
            this.timezoneBox.TabIndex = 11;
            // 
            // longitudeTextBox
            // 
            this.longitudeTextBox.Location = new System.Drawing.Point(247, 224);
            this.longitudeTextBox.Name = "longitudeTextBox";
            this.longitudeTextBox.Size = new System.Drawing.Size(89, 20);
            this.longitudeTextBox.TabIndex = 9;
            // 
            // latitudeTextBox
            // 
            this.latitudeTextBox.Location = new System.Drawing.Point(77, 224);
            this.latitudeTextBox.Name = "latitudeTextBox";
            this.latitudeTextBox.Size = new System.Drawing.Size(107, 20);
            this.latitudeTextBox.TabIndex = 8;
            // 
            // longitudeLabel
            // 
            this.longitudeLabel.AutoSize = true;
            this.longitudeLabel.Location = new System.Drawing.Point(192, 227);
            this.longitudeLabel.Name = "longitudeLabel";
            this.longitudeLabel.Size = new System.Drawing.Size(54, 13);
            this.longitudeLabel.TabIndex = 27;
            this.longitudeLabel.Text = "Longitude";
            // 
            // latitudeLabel
            // 
            this.latitudeLabel.AutoSize = true;
            this.latitudeLabel.Location = new System.Drawing.Point(27, 227);
            this.latitudeLabel.Name = "latitudeLabel";
            this.latitudeLabel.Size = new System.Drawing.Size(45, 13);
            this.latitudeLabel.TabIndex = 26;
            this.latitudeLabel.Text = "Latitude";
            // 
            // ScheduleDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(354, 406);
            this.Controls.Add(this.longitudeTextBox);
            this.Controls.Add(this.latitudeTextBox);
            this.Controls.Add(this.longitudeLabel);
            this.Controls.Add(this.latitudeLabel);
            this.Controls.Add(this.timezoneBox);
            this.Controls.Add(this.timezoneLabel);
            this.Controls.Add(this.checkPermissionButton);
            this.Controls.Add(this.sunriseSunsetDurationBox);
            this.Controls.Add(this.grantPermissionButton);
            this.Controls.Add(this.sunriseSunsetDurationLabel);
            this.Controls.Add(this.sunsetTimePicker);
            this.Controls.Add(this.sunriseTimePicker);
            this.Controls.Add(this.sunsetTimeLabel);
            this.Controls.Add(this.sunriseTimeLabel);
            this.Controls.Add(this.locationPermissionLabel);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.locationBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::WinDynamicDesktop.Properties.Resources.AppIcon;
            this.MaximizeBox = false;
            this.Name = "ScheduleDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configure Timing";
            this.Load += new System.EventHandler(this.InputDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sunriseSunsetDurationBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.TextBox locationBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label locationPermissionLabel;
        private System.Windows.Forms.Label sunriseTimeLabel;
        private System.Windows.Forms.Label sunsetTimeLabel;
        private System.Windows.Forms.DateTimePicker sunriseTimePicker;
        private System.Windows.Forms.DateTimePicker sunsetTimePicker;
        private System.Windows.Forms.Label sunriseSunsetDurationLabel;
        private System.Windows.Forms.Button grantPermissionButton;
        private System.Windows.Forms.NumericUpDown sunriseSunsetDurationBox;
        private System.Windows.Forms.Button checkPermissionButton;
        private System.Windows.Forms.Label timezoneLabel;
        private System.Windows.Forms.ComboBox timezoneBox;
        private System.Windows.Forms.TextBox longitudeTextBox;
        private System.Windows.Forms.TextBox latitudeTextBox;
        private System.Windows.Forms.Label longitudeLabel;
        private System.Windows.Forms.Label latitudeLabel;
    }
}

