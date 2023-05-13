
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
            this.buttonDay1 = new System.Windows.Forms.Button();
            this.buttonDay2 = new System.Windows.Forms.Button();
            this.buttonDay3 = new System.Windows.Forms.Button();
            this.buttonDay4 = new System.Windows.Forms.Button();
            this.buttonDay5 = new System.Windows.Forms.Button();
            this.textBoxCitySearch = new System.Windows.Forms.TextBox();
            this.buttonReboot = new System.Windows.Forms.Button();
            this.buttonPreviousTime = new System.Windows.Forms.Button();
            this.buttonNextTime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDay1
            // 
            this.buttonDay1.Location = new System.Drawing.Point(385, 105);
            this.buttonDay1.Name = "buttonDay1";
            this.buttonDay1.Size = new System.Drawing.Size(150, 150);
            this.buttonDay1.TabIndex = 0;
            this.buttonDay1.Text = "Сегодня";
            this.buttonDay1.UseVisualStyleBackColor = true;
            // 
            // buttonDay2
            // 
            this.buttonDay2.Location = new System.Drawing.Point(560, 105);
            this.buttonDay2.Name = "buttonDay2";
            this.buttonDay2.Size = new System.Drawing.Size(150, 150);
            this.buttonDay2.TabIndex = 1;
            this.buttonDay2.Text = "Завтра";
            this.buttonDay2.UseVisualStyleBackColor = true;
            // 
            // buttonDay3
            // 
            this.buttonDay3.Location = new System.Drawing.Point(385, 280);
            this.buttonDay3.Name = "buttonDay3";
            this.buttonDay3.Size = new System.Drawing.Size(150, 150);
            this.buttonDay3.TabIndex = 2;
            this.buttonDay3.Text = "Послезавтра";
            this.buttonDay3.UseVisualStyleBackColor = true;
            // 
            // buttonDay4
            // 
            this.buttonDay4.Location = new System.Drawing.Point(560, 280);
            this.buttonDay4.Name = "buttonDay4";
            this.buttonDay4.Size = new System.Drawing.Size(150, 150);
            this.buttonDay4.TabIndex = 3;
            this.buttonDay4.Text = "Через 2 дня";
            this.buttonDay4.UseVisualStyleBackColor = true;
            // 
            // buttonDay5
            // 
            this.buttonDay5.Location = new System.Drawing.Point(385, 455);
            this.buttonDay5.Name = "buttonDay5";
            this.buttonDay5.Size = new System.Drawing.Size(150, 150);
            this.buttonDay5.TabIndex = 4;
            this.buttonDay5.Text = "Через 3 дня";
            this.buttonDay5.UseVisualStyleBackColor = true;
            // 
            // textBoxCitySearch
            // 
            this.textBoxCitySearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCitySearch.Location = new System.Drawing.Point(60, 50);
            this.textBoxCitySearch.Name = "textBoxCitySearch";
            this.textBoxCitySearch.Size = new System.Drawing.Size(300, 29);
            this.textBoxCitySearch.TabIndex = 5;
            this.textBoxCitySearch.Text = "Город...";
            // 
            // buttonReboot
            // 
            this.buttonReboot.Location = new System.Drawing.Point(385, 50);
            this.buttonReboot.Name = "buttonReboot";
            this.buttonReboot.Size = new System.Drawing.Size(30, 30);
            this.buttonReboot.TabIndex = 6;
            this.buttonReboot.UseVisualStyleBackColor = true;
            // 
            // buttonPreviousTime
            // 
            this.buttonPreviousTime.Location = new System.Drawing.Point(100, 480);
            this.buttonPreviousTime.Name = "buttonPreviousTime";
            this.buttonPreviousTime.Size = new System.Drawing.Size(70, 90);
            this.buttonPreviousTime.TabIndex = 7;
            this.buttonPreviousTime.Text = "<-";
            this.buttonPreviousTime.UseVisualStyleBackColor = true;
            // 
            // buttonNextTime
            // 
            this.buttonNextTime.Location = new System.Drawing.Point(250, 480);
            this.buttonNextTime.Name = "buttonNextTime";
            this.buttonNextTime.Size = new System.Drawing.Size(70, 90);
            this.buttonNextTime.TabIndex = 9;
            this.buttonNextTime.Text = "->";
            this.buttonNextTime.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.buttonNextTime);
            this.Controls.Add(this.buttonPreviousTime);
            this.Controls.Add(this.buttonReboot);
            this.Controls.Add(this.textBoxCitySearch);
            this.Controls.Add(this.buttonDay5);
            this.Controls.Add(this.buttonDay4);
            this.Controls.Add(this.buttonDay3);
            this.Controls.Add(this.buttonDay2);
            this.Controls.Add(this.buttonDay1);
            this.Name = "MainForm";
            this.Text = "Прогноз погоды";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDay1;
        private System.Windows.Forms.Button buttonDay2;
        private System.Windows.Forms.Button buttonDay3;
        private System.Windows.Forms.Button buttonDay4;
        private System.Windows.Forms.Button buttonDay5;
        private System.Windows.Forms.TextBox textBoxCitySearch;
        private System.Windows.Forms.Button buttonReboot;
        private System.Windows.Forms.Button buttonPreviousTime;
        private System.Windows.Forms.Button buttonNextTime;
    }
}

