
namespace WeatherForecastApp
{
    partial class Window
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
            this.labelLocationSelection = new System.Windows.Forms.Label();
            this.comboBoxLocationList = new System.Windows.Forms.ComboBox();
            this.buttonGetForecast = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxCurrentWeather = new System.Windows.Forms.GroupBox();
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
            this.groupBox1.SuspendLayout();
            this.groupBoxCurrentWeather.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeatherConditionIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGetCurrentWeather
            // 
            this.buttonGetCurrentWeather.Location = new System.Drawing.Point(6, 69);
            this.buttonGetCurrentWeather.Name = "buttonGetCurrentWeather";
            this.buttonGetCurrentWeather.Size = new System.Drawing.Size(105, 61);
            this.buttonGetCurrentWeather.TabIndex = 6;
            this.buttonGetCurrentWeather.Text = "Узнать текущую погоду";
            this.buttonGetCurrentWeather.UseVisualStyleBackColor = true;
            this.buttonGetCurrentWeather.Click += new System.EventHandler(this.buttonGetCurrentWeather_Click);
            // 
            // labelLocationSelection
            // 
            this.labelLocationSelection.AutoSize = true;
            this.labelLocationSelection.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLocationSelection.Location = new System.Drawing.Point(6, 19);
            this.labelLocationSelection.Name = "labelLocationSelection";
            this.labelLocationSelection.Size = new System.Drawing.Size(128, 18);
            this.labelLocationSelection.TabIndex = 10;
            this.labelLocationSelection.Text = "Выбор города";
            // 
            // comboBoxLocationList
            // 
            this.comboBoxLocationList.FormattingEnabled = true;
            this.comboBoxLocationList.Location = new System.Drawing.Point(6, 40);
            this.comboBoxLocationList.Name = "comboBoxLocationList";
            this.comboBoxLocationList.Size = new System.Drawing.Size(220, 23);
            this.comboBoxLocationList.TabIndex = 11;
            // 
            // buttonGetForecast
            // 
            this.buttonGetForecast.Location = new System.Drawing.Point(121, 69);
            this.buttonGetForecast.Name = "buttonGetForecast";
            this.buttonGetForecast.Size = new System.Drawing.Size(105, 61);
            this.buttonGetForecast.TabIndex = 12;
            this.buttonGetForecast.Text = "Узнать прогноз на следующие 5 дней";
            this.buttonGetForecast.UseVisualStyleBackColor = true;
            this.buttonGetForecast.Click += new System.EventHandler(this.buttonGetForecast_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.labelLocationSelection);
            this.groupBox1.Controls.Add(this.buttonGetForecast);
            this.groupBox1.Controls.Add(this.buttonGetCurrentWeather);
            this.groupBox1.Controls.Add(this.comboBoxLocationList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 152);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // groupBoxCurrentWeather
            // 
            this.groupBoxCurrentWeather.AutoSize = true;
            this.groupBoxCurrentWeather.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxCurrentWeather.Controls.Add(this.groupBox3);
            this.groupBoxCurrentWeather.Controls.Add(this.groupBox2);
            this.groupBoxCurrentWeather.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxCurrentWeather.ForeColor = System.Drawing.Color.Black;
            this.groupBoxCurrentWeather.Location = new System.Drawing.Point(250, 12);
            this.groupBoxCurrentWeather.Name = "groupBoxCurrentWeather";
            this.groupBoxCurrentWeather.Size = new System.Drawing.Size(234, 302);
            this.groupBoxCurrentWeather.TabIndex = 14;
            this.groupBoxCurrentWeather.TabStop = false;
            this.groupBoxCurrentWeather.Text = "Погода сейчас";
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
            this.groupBox3.Size = new System.Drawing.Size(222, 144);
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
            this.groupBox2.Size = new System.Drawing.Size(222, 111);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // pictureBoxWeatherConditionIcon
            // 
            this.pictureBoxWeatherConditionIcon.BackColor = System.Drawing.Color.LightGray;
            this.pictureBoxWeatherConditionIcon.Location = new System.Drawing.Point(0, 9);
            this.pictureBoxWeatherConditionIcon.Name = "pictureBoxWeatherConditionIcon";
            this.pictureBoxWeatherConditionIcon.Size = new System.Drawing.Size(100, 100);
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
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 324);
            this.Controls.Add(this.groupBoxCurrentWeather);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Window";
            this.Text = "Прогноз погоды";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxCurrentWeather.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeatherConditionIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxCitySearch;
        private System.Windows.Forms.Button buttonGetCurrentWeather;
        private System.Windows.Forms.Label labelLocationSelection;
        private System.Windows.Forms.ComboBox comboBoxLocationList;
        private System.Windows.Forms.Button buttonGetForecast;
        private System.Windows.Forms.GroupBox groupBox1;
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
    }
}

