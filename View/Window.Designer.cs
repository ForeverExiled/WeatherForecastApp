
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
            buttonGetCurrentWeather = new System.Windows.Forms.Button();
            comboBoxLocationList = new System.Windows.Forms.ComboBox();
            buttonGetForecast = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBoxCurrentWeather = new System.Windows.Forms.GroupBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            labelTemperature = new System.Windows.Forms.Label();
            labelWindInfo = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            labelHumidity = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            labelPressure = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            labelFeelsLike = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            pictureBoxWeatherConditionIcon = new System.Windows.Forms.PictureBox();
            labelCurrentWeatherDateTime = new System.Windows.Forms.Label();
            labelWeatherDescription = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            groupBoxCurrentWeather.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWeatherConditionIcon).BeginInit();
            SuspendLayout();
            // 
            // buttonGetCurrentWeather
            // 
            buttonGetCurrentWeather.Location = new System.Drawing.Point(6, 57);
            buttonGetCurrentWeather.Name = "buttonGetCurrentWeather";
            buttonGetCurrentWeather.Size = new System.Drawing.Size(70, 40);
            buttonGetCurrentWeather.TabIndex = 6;
            buttonGetCurrentWeather.Text = "Погода\r\nсейчас";
            buttonGetCurrentWeather.UseVisualStyleBackColor = true;
            buttonGetCurrentWeather.Click += buttonGetCurrentWeather_Click;
            // 
            // comboBoxLocationList
            // 
            comboBoxLocationList.FormattingEnabled = true;
            comboBoxLocationList.Location = new System.Drawing.Point(6, 28);
            comboBoxLocationList.Name = "comboBoxLocationList";
            comboBoxLocationList.Size = new System.Drawing.Size(220, 23);
            comboBoxLocationList.TabIndex = 11;
            // 
            // buttonGetForecast
            // 
            buttonGetForecast.Location = new System.Drawing.Point(155, 57);
            buttonGetForecast.Name = "buttonGetForecast";
            buttonGetForecast.Size = new System.Drawing.Size(70, 40);
            buttonGetForecast.TabIndex = 12;
            buttonGetForecast.Text = "Прогноз\r\nна 5 дней";
            buttonGetForecast.UseVisualStyleBackColor = true;
            buttonGetForecast.Click += buttonGetForecast_Click;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(buttonGetForecast);
            groupBox1.Controls.Add(buttonGetCurrentWeather);
            groupBox1.Controls.Add(comboBoxLocationList);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(232, 119);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Выбор города";
            // 
            // groupBoxCurrentWeather
            // 
            groupBoxCurrentWeather.AutoSize = true;
            groupBoxCurrentWeather.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            groupBoxCurrentWeather.Controls.Add(groupBox3);
            groupBoxCurrentWeather.Controls.Add(groupBox2);
            groupBoxCurrentWeather.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBoxCurrentWeather.ForeColor = System.Drawing.Color.Black;
            groupBoxCurrentWeather.Location = new System.Drawing.Point(250, 12);
            groupBoxCurrentWeather.Name = "groupBoxCurrentWeather";
            groupBoxCurrentWeather.Size = new System.Drawing.Size(234, 302);
            groupBoxCurrentWeather.TabIndex = 14;
            groupBoxCurrentWeather.TabStop = false;
            groupBoxCurrentWeather.Text = "нет данных";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(labelTemperature);
            groupBox3.Controls.Add(labelWindInfo);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(labelHumidity);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(labelPressure);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(labelFeelsLike);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new System.Drawing.Point(6, 136);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(222, 144);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(20, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(80, 15);
            label1.TabIndex = 3;
            label1.Text = "Температура:";
            // 
            // labelTemperature
            // 
            labelTemperature.AutoSize = true;
            labelTemperature.Location = new System.Drawing.Point(106, 19);
            labelTemperature.Name = "labelTemperature";
            labelTemperature.Size = new System.Drawing.Size(70, 15);
            labelTemperature.TabIndex = 4;
            labelTemperature.Text = "нет данных";
            labelTemperature.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelWindInfo
            // 
            labelWindInfo.AutoSize = true;
            labelWindInfo.Location = new System.Drawing.Point(106, 118);
            labelWindInfo.Name = "labelWindInfo";
            labelWindInfo.Size = new System.Drawing.Size(70, 15);
            labelWindInfo.TabIndex = 13;
            labelWindInfo.Text = "нет данных";
            labelWindInfo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(5, 43);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(95, 15);
            label3.TabIndex = 5;
            label3.Text = "Ощущается как:";
            // 
            // labelHumidity
            // 
            labelHumidity.AutoSize = true;
            labelHumidity.Location = new System.Drawing.Point(106, 93);
            labelHumidity.Name = "labelHumidity";
            labelHumidity.Size = new System.Drawing.Size(70, 15);
            labelHumidity.TabIndex = 12;
            labelHumidity.Text = "нет данных";
            labelHumidity.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(38, 67);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(62, 15);
            label4.TabIndex = 6;
            label4.Text = "Давление:";
            // 
            // labelPressure
            // 
            labelPressure.AutoSize = true;
            labelPressure.Location = new System.Drawing.Point(106, 67);
            labelPressure.Name = "labelPressure";
            labelPressure.Size = new System.Drawing.Size(70, 15);
            labelPressure.TabIndex = 11;
            labelPressure.Text = "нет данных";
            labelPressure.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(31, 93);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(69, 15);
            label5.TabIndex = 7;
            label5.Text = "Влажность:";
            // 
            // labelFeelsLike
            // 
            labelFeelsLike.AutoSize = true;
            labelFeelsLike.Location = new System.Drawing.Point(106, 43);
            labelFeelsLike.Name = "labelFeelsLike";
            labelFeelsLike.Size = new System.Drawing.Size(70, 15);
            labelFeelsLike.TabIndex = 10;
            labelFeelsLike.Text = "нет данных";
            labelFeelsLike.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(59, 118);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(41, 15);
            label6.TabIndex = 8;
            label6.Text = "Ветер:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBoxWeatherConditionIcon);
            groupBox2.Controls.Add(labelCurrentWeatherDateTime);
            groupBox2.Controls.Add(labelWeatherDescription);
            groupBox2.Location = new System.Drawing.Point(6, 19);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(222, 111);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            // 
            // pictureBoxWeatherConditionIcon
            // 
            pictureBoxWeatherConditionIcon.BackColor = System.Drawing.Color.LightGray;
            pictureBoxWeatherConditionIcon.Location = new System.Drawing.Point(0, 9);
            pictureBoxWeatherConditionIcon.Name = "pictureBoxWeatherConditionIcon";
            pictureBoxWeatherConditionIcon.Size = new System.Drawing.Size(100, 100);
            pictureBoxWeatherConditionIcon.TabIndex = 2;
            pictureBoxWeatherConditionIcon.TabStop = false;
            // 
            // labelCurrentWeatherDateTime
            // 
            labelCurrentWeatherDateTime.AutoSize = true;
            labelCurrentWeatherDateTime.BackColor = System.Drawing.Color.Transparent;
            labelCurrentWeatherDateTime.Location = new System.Drawing.Point(106, 14);
            labelCurrentWeatherDateTime.Name = "labelCurrentWeatherDateTime";
            labelCurrentWeatherDateTime.Size = new System.Drawing.Size(70, 15);
            labelCurrentWeatherDateTime.TabIndex = 1;
            labelCurrentWeatherDateTime.Text = "нет данных";
            // 
            // labelWeatherDescription
            // 
            labelWeatherDescription.AutoSize = true;
            labelWeatherDescription.Location = new System.Drawing.Point(106, 56);
            labelWeatherDescription.Name = "labelWeatherDescription";
            labelWeatherDescription.Size = new System.Drawing.Size(70, 15);
            labelWeatherDescription.TabIndex = 9;
            labelWeatherDescription.Text = "нет данных";
            // 
            // Window
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(496, 324);
            Controls.Add(groupBoxCurrentWeather);
            Controls.Add(groupBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Name = "Window";
            Text = "Прогноз погоды";
            FormClosing += Window_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBoxCurrentWeather.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWeatherConditionIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button buttonGetCurrentWeather;
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

