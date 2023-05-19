
namespace WeatherForecastApp
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGetCurrentWeather = new System.Windows.Forms.Button();
            this.buttonGetForecast = new System.Windows.Forms.Button();
            this.groupBoxCurrentWeather = new System.Windows.Forms.GroupBox();
            this.buttonNextTimestamp = new System.Windows.Forms.Button();
            this.buttonPreviousTimestamp = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.labelWindInfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelHumidity = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelPressure = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelFeelsLike = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBoxWeatherConditionIcon = new System.Windows.Forms.PictureBox();
            this.labelCurrentWeatherDateTime = new System.Windows.Forms.Label();
            this.labelWeatherDescription = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxCity = new System.Windows.Forms.GroupBox();
            this.groupBoxForecast = new System.Windows.Forms.GroupBox();
            this.buttonDay5 = new System.Windows.Forms.Button();
            this.buttonDay4 = new System.Windows.Forms.Button();
            this.buttonDay3 = new System.Windows.Forms.Button();
            this.buttonDay2 = new System.Windows.Forms.Button();
            this.buttonDay1 = new System.Windows.Forms.Button();
            this.pictureBoxNight5 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDay5 = new System.Windows.Forms.PictureBox();
            this.pictureBoxNight4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDay4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxNight3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDay3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxNight2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDay2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxNight1 = new System.Windows.Forms.PictureBox();
            this.groupBoxDay5 = new System.Windows.Forms.GroupBox();
            this.labelDay5 = new System.Windows.Forms.Label();
            this.groupBoxDay4 = new System.Windows.Forms.GroupBox();
            this.labelDay4 = new System.Windows.Forms.Label();
            this.groupBoxDay3 = new System.Windows.Forms.GroupBox();
            this.labelDay3 = new System.Windows.Forms.Label();
            this.groupBoxDay2 = new System.Windows.Forms.GroupBox();
            this.labelDay2 = new System.Windows.Forms.Label();
            this.pictureBoxDay1 = new System.Windows.Forms.PictureBox();
            this.groupBoxDay1 = new System.Windows.Forms.GroupBox();
            this.labelDay1 = new System.Windows.Forms.Label();
            this.groupBoxCurrentWeather.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeatherConditionIcon)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBoxCity.SuspendLayout();
            this.groupBoxForecast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNight5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDay5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNight4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDay4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNight3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDay3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNight2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDay2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNight1)).BeginInit();
            this.groupBoxDay5.SuspendLayout();
            this.groupBoxDay4.SuspendLayout();
            this.groupBoxDay3.SuspendLayout();
            this.groupBoxDay2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDay1)).BeginInit();
            this.groupBoxDay1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGetCurrentWeather
            // 
            this.buttonGetCurrentWeather.Location = new System.Drawing.Point(12, 27);
            this.buttonGetCurrentWeather.Name = "buttonGetCurrentWeather";
            this.buttonGetCurrentWeather.Size = new System.Drawing.Size(116, 25);
            this.buttonGetCurrentWeather.TabIndex = 6;
            this.buttonGetCurrentWeather.Text = "Погода сейчас";
            this.buttonGetCurrentWeather.UseVisualStyleBackColor = true;
            this.buttonGetCurrentWeather.Click += new System.EventHandler(this.buttonGetCurrentWeather_Click);
            // 
            // buttonGetForecast
            // 
            this.buttonGetForecast.Location = new System.Drawing.Point(134, 27);
            this.buttonGetForecast.Name = "buttonGetForecast";
            this.buttonGetForecast.Size = new System.Drawing.Size(116, 25);
            this.buttonGetForecast.TabIndex = 12;
            this.buttonGetForecast.Text = "Прогноз на 5 дней";
            this.buttonGetForecast.UseVisualStyleBackColor = true;
            this.buttonGetForecast.Click += new System.EventHandler(this.buttonGetForecast_Click);
            // 
            // groupBoxCurrentWeather
            // 
            this.groupBoxCurrentWeather.AutoSize = true;
            this.groupBoxCurrentWeather.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxCurrentWeather.Controls.Add(this.buttonNextTimestamp);
            this.groupBoxCurrentWeather.Controls.Add(this.buttonPreviousTimestamp);
            this.groupBoxCurrentWeather.Controls.Add(this.groupBox3);
            this.groupBoxCurrentWeather.Controls.Add(this.groupBox2);
            this.groupBoxCurrentWeather.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxCurrentWeather.ForeColor = System.Drawing.Color.Black;
            this.groupBoxCurrentWeather.Location = new System.Drawing.Point(6, 22);
            this.groupBoxCurrentWeather.Name = "groupBoxCurrentWeather";
            this.groupBoxCurrentWeather.Size = new System.Drawing.Size(212, 350);
            this.groupBoxCurrentWeather.TabIndex = 14;
            this.groupBoxCurrentWeather.TabStop = false;
            this.groupBoxCurrentWeather.Text = "Погода сейчас";
            // 
            // buttonNextTimestamp
            // 
            this.buttonNextTimestamp.Enabled = false;
            this.buttonNextTimestamp.Location = new System.Drawing.Point(149, 288);
            this.buttonNextTimestamp.Name = "buttonNextTimestamp";
            this.buttonNextTimestamp.Size = new System.Drawing.Size(57, 40);
            this.buttonNextTimestamp.TabIndex = 17;
            this.buttonNextTimestamp.Text = "нет\r\nданных";
            this.buttonNextTimestamp.UseVisualStyleBackColor = true;
            this.buttonNextTimestamp.Click += new System.EventHandler(this.buttonNextTimestamp_Click);
            // 
            // buttonPreviousTimestamp
            // 
            this.buttonPreviousTimestamp.Enabled = false;
            this.buttonPreviousTimestamp.Location = new System.Drawing.Point(6, 288);
            this.buttonPreviousTimestamp.Name = "buttonPreviousTimestamp";
            this.buttonPreviousTimestamp.Size = new System.Drawing.Size(57, 40);
            this.buttonPreviousTimestamp.TabIndex = 16;
            this.buttonPreviousTimestamp.Text = "нет\r\nданных";
            this.buttonPreviousTimestamp.UseVisualStyleBackColor = true;
            this.buttonPreviousTimestamp.Click += new System.EventHandler(this.buttonPreviousTimestamp_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.labelTemperature);
            this.groupBox3.Controls.Add(this.labelWindInfo);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.labelHumidity);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.labelPressure);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.labelFeelsLike);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(6, 136);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 144);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Температура:";
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Location = new System.Drawing.Point(106, 19);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(70, 15);
            this.labelTemperature.TabIndex = 4;
            this.labelTemperature.Text = "нет данных";
            this.labelTemperature.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelWindInfo
            // 
            this.labelWindInfo.AutoSize = true;
            this.labelWindInfo.Location = new System.Drawing.Point(106, 118);
            this.labelWindInfo.Name = "labelWindInfo";
            this.labelWindInfo.Size = new System.Drawing.Size(70, 15);
            this.labelWindInfo.TabIndex = 13;
            this.labelWindInfo.Text = "нет данных";
            this.labelWindInfo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ощущается как:";
            // 
            // labelHumidity
            // 
            this.labelHumidity.AutoSize = true;
            this.labelHumidity.Location = new System.Drawing.Point(106, 93);
            this.labelHumidity.Name = "labelHumidity";
            this.labelHumidity.Size = new System.Drawing.Size(70, 15);
            this.labelHumidity.TabIndex = 12;
            this.labelHumidity.Text = "нет данных";
            this.labelHumidity.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Давление:";
            // 
            // labelPressure
            // 
            this.labelPressure.AutoSize = true;
            this.labelPressure.Location = new System.Drawing.Point(106, 67);
            this.labelPressure.Name = "labelPressure";
            this.labelPressure.Size = new System.Drawing.Size(70, 15);
            this.labelPressure.TabIndex = 11;
            this.labelPressure.Text = "нет данных";
            this.labelPressure.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Влажность:";
            // 
            // labelFeelsLike
            // 
            this.labelFeelsLike.AutoSize = true;
            this.labelFeelsLike.Location = new System.Drawing.Point(106, 43);
            this.labelFeelsLike.Name = "labelFeelsLike";
            this.labelFeelsLike.Size = new System.Drawing.Size(70, 15);
            this.labelFeelsLike.TabIndex = 10;
            this.labelFeelsLike.Text = "нет данных";
            this.labelFeelsLike.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ветер:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBoxWeatherConditionIcon);
            this.groupBox2.Controls.Add(this.labelCurrentWeatherDateTime);
            this.groupBox2.Controls.Add(this.labelWeatherDescription);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 111);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // pictureBoxWeatherConditionIcon
            // 
            this.pictureBoxWeatherConditionIcon.BackColor = System.Drawing.Color.LightGray;
            this.pictureBoxWeatherConditionIcon.Location = new System.Drawing.Point(0, 9);
            this.pictureBoxWeatherConditionIcon.Name = "pictureBoxWeatherConditionIcon";
            this.pictureBoxWeatherConditionIcon.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxWeatherConditionIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWeatherConditionIcon.TabIndex = 2;
            this.pictureBoxWeatherConditionIcon.TabStop = false;
            // 
            // labelCurrentWeatherDateTime
            // 
            this.labelCurrentWeatherDateTime.AutoSize = true;
            this.labelCurrentWeatherDateTime.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentWeatherDateTime.Location = new System.Drawing.Point(106, 14);
            this.labelCurrentWeatherDateTime.Name = "labelCurrentWeatherDateTime";
            this.labelCurrentWeatherDateTime.Size = new System.Drawing.Size(70, 15);
            this.labelCurrentWeatherDateTime.TabIndex = 1;
            this.labelCurrentWeatherDateTime.Text = "нет данных";
            // 
            // labelWeatherDescription
            // 
            this.labelWeatherDescription.AutoSize = true;
            this.labelWeatherDescription.Location = new System.Drawing.Point(106, 56);
            this.labelWeatherDescription.Name = "labelWeatherDescription";
            this.labelWeatherDescription.Size = new System.Drawing.Size(70, 15);
            this.labelWeatherDescription.TabIndex = 9;
            this.labelWeatherDescription.Text = "нет данных";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Settings});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(650, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem_Settings
            // 
            this.toolStripMenuItem_Settings.Name = "toolStripMenuItem_Settings";
            this.toolStripMenuItem_Settings.Size = new System.Drawing.Size(79, 20);
            this.toolStripMenuItem_Settings.Text = "Настройки";
            this.toolStripMenuItem_Settings.Click += new System.EventHandler(this.toolStripMenuItem_Settings_Click);
            // 
            // groupBoxCity
            // 
            this.groupBoxCity.AutoSize = true;
            this.groupBoxCity.Controls.Add(this.groupBoxForecast);
            this.groupBoxCity.Controls.Add(this.groupBoxCurrentWeather);
            this.groupBoxCity.Location = new System.Drawing.Point(12, 58);
            this.groupBoxCity.Name = "groupBoxCity";
            this.groupBoxCity.Size = new System.Drawing.Size(626, 394);
            this.groupBoxCity.TabIndex = 16;
            this.groupBoxCity.TabStop = false;
            this.groupBoxCity.Text = "нет данных";
            // 
            // groupBoxForecast
            // 
            this.groupBoxForecast.AutoSize = true;
            this.groupBoxForecast.Controls.Add(this.buttonDay5);
            this.groupBoxForecast.Controls.Add(this.buttonDay4);
            this.groupBoxForecast.Controls.Add(this.buttonDay3);
            this.groupBoxForecast.Controls.Add(this.buttonDay2);
            this.groupBoxForecast.Controls.Add(this.buttonDay1);
            this.groupBoxForecast.Controls.Add(this.pictureBoxNight5);
            this.groupBoxForecast.Controls.Add(this.pictureBoxDay5);
            this.groupBoxForecast.Controls.Add(this.pictureBoxNight4);
            this.groupBoxForecast.Controls.Add(this.pictureBoxDay4);
            this.groupBoxForecast.Controls.Add(this.pictureBoxNight3);
            this.groupBoxForecast.Controls.Add(this.pictureBoxDay3);
            this.groupBoxForecast.Controls.Add(this.pictureBoxNight2);
            this.groupBoxForecast.Controls.Add(this.pictureBoxDay2);
            this.groupBoxForecast.Controls.Add(this.pictureBoxNight1);
            this.groupBoxForecast.Controls.Add(this.groupBoxDay5);
            this.groupBoxForecast.Controls.Add(this.groupBoxDay4);
            this.groupBoxForecast.Controls.Add(this.groupBoxDay3);
            this.groupBoxForecast.Controls.Add(this.groupBoxDay2);
            this.groupBoxForecast.Controls.Add(this.pictureBoxDay1);
            this.groupBoxForecast.Controls.Add(this.groupBoxDay1);
            this.groupBoxForecast.Location = new System.Drawing.Point(224, 22);
            this.groupBoxForecast.Name = "groupBoxForecast";
            this.groupBoxForecast.Size = new System.Drawing.Size(396, 350);
            this.groupBoxForecast.TabIndex = 15;
            this.groupBoxForecast.TabStop = false;
            this.groupBoxForecast.Text = "Прогноз на 5 дней";
            // 
            // buttonDay5
            // 
            this.buttonDay5.Location = new System.Drawing.Point(320, 279);
            this.buttonDay5.Name = "buttonDay5";
            this.buttonDay5.Size = new System.Drawing.Size(69, 47);
            this.buttonDay5.TabIndex = 34;
            this.buttonDay5.Text = "Раскрыть";
            this.buttonDay5.UseVisualStyleBackColor = true;
            this.buttonDay5.Click += new System.EventHandler(this.buttonDay5_Click);
            // 
            // buttonDay4
            // 
            this.buttonDay4.Location = new System.Drawing.Point(320, 216);
            this.buttonDay4.Name = "buttonDay4";
            this.buttonDay4.Size = new System.Drawing.Size(69, 47);
            this.buttonDay4.TabIndex = 33;
            this.buttonDay4.Text = "Раскрыть";
            this.buttonDay4.UseVisualStyleBackColor = true;
            this.buttonDay4.Click += new System.EventHandler(this.buttonDay4_Click);
            // 
            // buttonDay3
            // 
            this.buttonDay3.Location = new System.Drawing.Point(321, 154);
            this.buttonDay3.Name = "buttonDay3";
            this.buttonDay3.Size = new System.Drawing.Size(69, 47);
            this.buttonDay3.TabIndex = 32;
            this.buttonDay3.Text = "Раскрыть";
            this.buttonDay3.UseVisualStyleBackColor = true;
            this.buttonDay3.Click += new System.EventHandler(this.buttonDay3_Click);
            // 
            // buttonDay2
            // 
            this.buttonDay2.Location = new System.Drawing.Point(321, 90);
            this.buttonDay2.Name = "buttonDay2";
            this.buttonDay2.Size = new System.Drawing.Size(69, 47);
            this.buttonDay2.TabIndex = 31;
            this.buttonDay2.Text = "Раскрыть";
            this.buttonDay2.UseVisualStyleBackColor = true;
            this.buttonDay2.Click += new System.EventHandler(this.buttonDay2_Click);
            // 
            // buttonDay1
            // 
            this.buttonDay1.Location = new System.Drawing.Point(321, 28);
            this.buttonDay1.Name = "buttonDay1";
            this.buttonDay1.Size = new System.Drawing.Size(69, 47);
            this.buttonDay1.TabIndex = 30;
            this.buttonDay1.Text = "Раскрыть";
            this.buttonDay1.UseVisualStyleBackColor = true;
            this.buttonDay1.Click += new System.EventHandler(this.buttonDay1_Click);
            // 
            // pictureBoxNight5
            // 
            this.pictureBoxNight5.BackColor = System.Drawing.Color.SlateBlue;
            this.pictureBoxNight5.Location = new System.Drawing.Point(266, 279);
            this.pictureBoxNight5.Name = "pictureBoxNight5";
            this.pictureBoxNight5.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxNight5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNight5.TabIndex = 29;
            this.pictureBoxNight5.TabStop = false;
            // 
            // pictureBoxDay5
            // 
            this.pictureBoxDay5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBoxDay5.Location = new System.Drawing.Point(212, 279);
            this.pictureBoxDay5.Name = "pictureBoxDay5";
            this.pictureBoxDay5.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxDay5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDay5.TabIndex = 28;
            this.pictureBoxDay5.TabStop = false;
            // 
            // pictureBoxNight4
            // 
            this.pictureBoxNight4.BackColor = System.Drawing.Color.SlateBlue;
            this.pictureBoxNight4.Location = new System.Drawing.Point(266, 216);
            this.pictureBoxNight4.Name = "pictureBoxNight4";
            this.pictureBoxNight4.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxNight4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNight4.TabIndex = 27;
            this.pictureBoxNight4.TabStop = false;
            // 
            // pictureBoxDay4
            // 
            this.pictureBoxDay4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBoxDay4.Location = new System.Drawing.Point(212, 216);
            this.pictureBoxDay4.Name = "pictureBoxDay4";
            this.pictureBoxDay4.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxDay4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDay4.TabIndex = 26;
            this.pictureBoxDay4.TabStop = false;
            // 
            // pictureBoxNight3
            // 
            this.pictureBoxNight3.BackColor = System.Drawing.Color.SlateBlue;
            this.pictureBoxNight3.Location = new System.Drawing.Point(266, 153);
            this.pictureBoxNight3.Name = "pictureBoxNight3";
            this.pictureBoxNight3.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxNight3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNight3.TabIndex = 25;
            this.pictureBoxNight3.TabStop = false;
            // 
            // pictureBoxDay3
            // 
            this.pictureBoxDay3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBoxDay3.Location = new System.Drawing.Point(212, 153);
            this.pictureBoxDay3.Name = "pictureBoxDay3";
            this.pictureBoxDay3.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxDay3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDay3.TabIndex = 24;
            this.pictureBoxDay3.TabStop = false;
            // 
            // pictureBoxNight2
            // 
            this.pictureBoxNight2.BackColor = System.Drawing.Color.SlateBlue;
            this.pictureBoxNight2.Location = new System.Drawing.Point(266, 90);
            this.pictureBoxNight2.Name = "pictureBoxNight2";
            this.pictureBoxNight2.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxNight2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNight2.TabIndex = 23;
            this.pictureBoxNight2.TabStop = false;
            // 
            // pictureBoxDay2
            // 
            this.pictureBoxDay2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBoxDay2.Location = new System.Drawing.Point(212, 90);
            this.pictureBoxDay2.Name = "pictureBoxDay2";
            this.pictureBoxDay2.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxDay2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDay2.TabIndex = 22;
            this.pictureBoxDay2.TabStop = false;
            // 
            // pictureBoxNight1
            // 
            this.pictureBoxNight1.BackColor = System.Drawing.Color.SlateBlue;
            this.pictureBoxNight1.Location = new System.Drawing.Point(266, 27);
            this.pictureBoxNight1.Name = "pictureBoxNight1";
            this.pictureBoxNight1.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxNight1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNight1.TabIndex = 21;
            this.pictureBoxNight1.TabStop = false;
            // 
            // groupBoxDay5
            // 
            this.groupBoxDay5.AutoSize = true;
            this.groupBoxDay5.Controls.Add(this.labelDay5);
            this.groupBoxDay5.Location = new System.Drawing.Point(6, 271);
            this.groupBoxDay5.Name = "groupBoxDay5";
            this.groupBoxDay5.Size = new System.Drawing.Size(200, 57);
            this.groupBoxDay5.TabIndex = 20;
            this.groupBoxDay5.TabStop = false;
            this.groupBoxDay5.Text = "нет данных";
            // 
            // labelDay5
            // 
            this.labelDay5.AutoSize = true;
            this.labelDay5.Location = new System.Drawing.Point(7, 23);
            this.labelDay5.Name = "labelDay5";
            this.labelDay5.Size = new System.Drawing.Size(69, 15);
            this.labelDay5.TabIndex = 1;
            this.labelDay5.Text = "нет данных";
            // 
            // groupBoxDay4
            // 
            this.groupBoxDay4.AutoSize = true;
            this.groupBoxDay4.Controls.Add(this.labelDay4);
            this.groupBoxDay4.Location = new System.Drawing.Point(6, 208);
            this.groupBoxDay4.Name = "groupBoxDay4";
            this.groupBoxDay4.Size = new System.Drawing.Size(200, 57);
            this.groupBoxDay4.TabIndex = 19;
            this.groupBoxDay4.TabStop = false;
            this.groupBoxDay4.Text = "нет данных";
            // 
            // labelDay4
            // 
            this.labelDay4.AutoSize = true;
            this.labelDay4.Location = new System.Drawing.Point(7, 23);
            this.labelDay4.Name = "labelDay4";
            this.labelDay4.Size = new System.Drawing.Size(69, 15);
            this.labelDay4.TabIndex = 1;
            this.labelDay4.Text = "нет данных";
            // 
            // groupBoxDay3
            // 
            this.groupBoxDay3.AutoSize = true;
            this.groupBoxDay3.Controls.Add(this.labelDay3);
            this.groupBoxDay3.Location = new System.Drawing.Point(6, 145);
            this.groupBoxDay3.Name = "groupBoxDay3";
            this.groupBoxDay3.Size = new System.Drawing.Size(200, 57);
            this.groupBoxDay3.TabIndex = 18;
            this.groupBoxDay3.TabStop = false;
            this.groupBoxDay3.Text = "нет данных";
            // 
            // labelDay3
            // 
            this.labelDay3.AutoSize = true;
            this.labelDay3.Location = new System.Drawing.Point(7, 23);
            this.labelDay3.Name = "labelDay3";
            this.labelDay3.Size = new System.Drawing.Size(69, 15);
            this.labelDay3.TabIndex = 1;
            this.labelDay3.Text = "нет данных";
            // 
            // groupBoxDay2
            // 
            this.groupBoxDay2.AutoSize = true;
            this.groupBoxDay2.Controls.Add(this.labelDay2);
            this.groupBoxDay2.Location = new System.Drawing.Point(6, 82);
            this.groupBoxDay2.Name = "groupBoxDay2";
            this.groupBoxDay2.Size = new System.Drawing.Size(200, 57);
            this.groupBoxDay2.TabIndex = 1;
            this.groupBoxDay2.TabStop = false;
            this.groupBoxDay2.Text = "Завтра";
            // 
            // labelDay2
            // 
            this.labelDay2.AutoSize = true;
            this.labelDay2.Location = new System.Drawing.Point(7, 23);
            this.labelDay2.Name = "labelDay2";
            this.labelDay2.Size = new System.Drawing.Size(69, 15);
            this.labelDay2.TabIndex = 1;
            this.labelDay2.Text = "нет данных";
            // 
            // pictureBoxDay1
            // 
            this.pictureBoxDay1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBoxDay1.Location = new System.Drawing.Point(212, 27);
            this.pictureBoxDay1.Name = "pictureBoxDay1";
            this.pictureBoxDay1.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxDay1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDay1.TabIndex = 17;
            this.pictureBoxDay1.TabStop = false;
            // 
            // groupBoxDay1
            // 
            this.groupBoxDay1.AutoSize = true;
            this.groupBoxDay1.Controls.Add(this.labelDay1);
            this.groupBoxDay1.Location = new System.Drawing.Point(6, 19);
            this.groupBoxDay1.Name = "groupBoxDay1";
            this.groupBoxDay1.Size = new System.Drawing.Size(200, 57);
            this.groupBoxDay1.TabIndex = 0;
            this.groupBoxDay1.TabStop = false;
            this.groupBoxDay1.Text = "Сегодня";
            // 
            // labelDay1
            // 
            this.labelDay1.AutoSize = true;
            this.labelDay1.Location = new System.Drawing.Point(7, 23);
            this.labelDay1.Name = "labelDay1";
            this.labelDay1.Size = new System.Drawing.Size(69, 15);
            this.labelDay1.TabIndex = 0;
            this.labelDay1.Text = "нет данных";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 462);
            this.Controls.Add(this.buttonGetCurrentWeather);
            this.Controls.Add(this.buttonGetForecast);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBoxCity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Прогноз погоды";
            this.groupBoxCurrentWeather.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeatherConditionIcon)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxCity.ResumeLayout(false);
            this.groupBoxCity.PerformLayout();
            this.groupBoxForecast.ResumeLayout(false);
            this.groupBoxForecast.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNight5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDay5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNight4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDay4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNight3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDay3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNight2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDay2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNight1)).EndInit();
            this.groupBoxDay5.ResumeLayout(false);
            this.groupBoxDay5.PerformLayout();
            this.groupBoxDay4.ResumeLayout(false);
            this.groupBoxDay4.PerformLayout();
            this.groupBoxDay3.ResumeLayout(false);
            this.groupBoxDay3.PerformLayout();
            this.groupBoxDay2.ResumeLayout(false);
            this.groupBoxDay2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDay1)).EndInit();
            this.groupBoxDay1.ResumeLayout(false);
            this.groupBoxDay1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonGetCurrentWeather;
        private System.Windows.Forms.Button buttonGetForecast;
        private System.Windows.Forms.GroupBox groupBoxCurrentWeather;
        private System.Windows.Forms.Label labelCurrentWeatherDateTime;
        private System.Windows.Forms.PictureBox pictureBoxWeatherConditionIcon;
        private System.Windows.Forms.Label labelWindInfo;
        private System.Windows.Forms.Label labelHumidity;
        private System.Windows.Forms.Label labelPressure;
        private System.Windows.Forms.Label labelFeelsLike;
        private System.Windows.Forms.Label labelWeatherDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Settings;
        private System.Windows.Forms.GroupBox groupBoxCity;
        private System.Windows.Forms.Button buttonPreviousTimestamp;
        private System.Windows.Forms.GroupBox groupBoxForecast;
        private System.Windows.Forms.Button buttonNextTimestamp;
        private System.Windows.Forms.GroupBox groupBoxDay5;
        private System.Windows.Forms.Label labelDay5;
        private System.Windows.Forms.GroupBox groupBoxDay4;
        private System.Windows.Forms.Label labelDay4;
        private System.Windows.Forms.GroupBox groupBoxDay3;
        private System.Windows.Forms.Label labelDay3;
        private System.Windows.Forms.GroupBox groupBoxDay2;
        private System.Windows.Forms.Label labelDay2;
        private System.Windows.Forms.PictureBox pictureBoxDay1;
        private System.Windows.Forms.GroupBox groupBoxDay1;
        private System.Windows.Forms.Label labelDay1;
        private System.Windows.Forms.PictureBox pictureBoxNight1;
        private System.Windows.Forms.PictureBox pictureBoxNight5;
        private System.Windows.Forms.PictureBox pictureBoxDay5;
        private System.Windows.Forms.PictureBox pictureBoxNight4;
        private System.Windows.Forms.PictureBox pictureBoxDay4;
        private System.Windows.Forms.PictureBox pictureBoxNight3;
        private System.Windows.Forms.PictureBox pictureBoxDay3;
        private System.Windows.Forms.PictureBox pictureBoxNight2;
        private System.Windows.Forms.PictureBox pictureBoxDay2;
        private System.Windows.Forms.Button buttonDay5;
        private System.Windows.Forms.Button buttonDay4;
        private System.Windows.Forms.Button buttonDay3;
        private System.Windows.Forms.Button buttonDay2;
        private System.Windows.Forms.Button buttonDay1;
    }
}

