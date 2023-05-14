
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
            labelLocationSelection = new System.Windows.Forms.Label();
            comboBoxLocationList = new System.Windows.Forms.ComboBox();
            button1 = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBoxCurrentWeather = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            groupBoxCurrentWeather.SuspendLayout();
            SuspendLayout();
            // 
            // buttonGetCurrentWeather
            // 
            buttonGetCurrentWeather.Location = new System.Drawing.Point(6, 69);
            buttonGetCurrentWeather.Name = "buttonGetCurrentWeather";
            buttonGetCurrentWeather.Size = new System.Drawing.Size(105, 61);
            buttonGetCurrentWeather.TabIndex = 6;
            buttonGetCurrentWeather.Text = "Узнать текущую погоду";
            buttonGetCurrentWeather.UseVisualStyleBackColor = true;
            buttonGetCurrentWeather.Click += buttonGetCurrentWeather_Click;
            // 
            // labelLocationSelection
            // 
            labelLocationSelection.AutoSize = true;
            labelLocationSelection.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelLocationSelection.Location = new System.Drawing.Point(6, 19);
            labelLocationSelection.Name = "labelLocationSelection";
            labelLocationSelection.Size = new System.Drawing.Size(128, 18);
            labelLocationSelection.TabIndex = 10;
            labelLocationSelection.Text = "Выбор города";
            // 
            // comboBoxLocationList
            // 
            comboBoxLocationList.FormattingEnabled = true;
            comboBoxLocationList.Items.AddRange(new object[] { "Тюмень" });
            comboBoxLocationList.Location = new System.Drawing.Point(6, 40);
            comboBoxLocationList.Name = "comboBoxLocationList";
            comboBoxLocationList.Size = new System.Drawing.Size(220, 23);
            comboBoxLocationList.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(121, 69);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(105, 61);
            button1.TabIndex = 12;
            button1.Text = "Узнать прогноз на следующие 5 дней";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(labelLocationSelection);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(buttonGetCurrentWeather);
            groupBox1.Controls.Add(comboBoxLocationList);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(232, 152);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // groupBoxCurrentWeather
            // 
            groupBoxCurrentWeather.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            groupBoxCurrentWeather.Controls.Add(label1);
            groupBoxCurrentWeather.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBoxCurrentWeather.ForeColor = System.Drawing.Color.Black;
            groupBoxCurrentWeather.Location = new System.Drawing.Point(12, 170);
            groupBoxCurrentWeather.Name = "groupBoxCurrentWeather";
            groupBoxCurrentWeather.Size = new System.Drawing.Size(232, 311);
            groupBoxCurrentWeather.TabIndex = 14;
            groupBoxCurrentWeather.TabStop = false;
            groupBoxCurrentWeather.Text = "Погода сейчас";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Location = new System.Drawing.Point(16, 78);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // Window
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(784, 661);
            Controls.Add(groupBoxCurrentWeather);
            Controls.Add(groupBox1);
            Name = "Window";
            Text = "Прогноз погоды";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxCurrentWeather.ResumeLayout(false);
            groupBoxCurrentWeather.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox textBoxCitySearch;
        private System.Windows.Forms.Button buttonGetCurrentWeather;
        private System.Windows.Forms.Label labelLocationSelection;
        private System.Windows.Forms.ComboBox comboBoxLocationList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxCurrentWeather;
        private System.Windows.Forms.Label label1;
    }
}

