
namespace WeatherForecastApp.View
{
    partial class SettingsWindow
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
            this.comboBoxLocationList = new System.Windows.Forms.ComboBox();
            this.groupBoxCitySelection = new System.Windows.Forms.GroupBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.groupBoxCitySelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxLocationList
            // 
            this.comboBoxLocationList.FormattingEnabled = true;
            this.comboBoxLocationList.Location = new System.Drawing.Point(6, 22);
            this.comboBoxLocationList.Name = "comboBoxLocationList";
            this.comboBoxLocationList.Size = new System.Drawing.Size(150, 23);
            this.comboBoxLocationList.TabIndex = 12;
            // 
            // groupBoxCitySelection
            // 
            this.groupBoxCitySelection.AutoSize = true;
            this.groupBoxCitySelection.Controls.Add(this.comboBoxLocationList);
            this.groupBoxCitySelection.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCitySelection.Name = "groupBoxCitySelection";
            this.groupBoxCitySelection.Size = new System.Drawing.Size(162, 67);
            this.groupBoxCitySelection.TabIndex = 13;
            this.groupBoxCitySelection.TabStop = false;
            this.groupBoxCitySelection.Text = "Выбор города";
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(95, 85);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(79, 36);
            this.buttonApply.TabIndex = 14;
            this.buttonApply.Text = "Применить";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 132);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.groupBoxCitySelection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SettingsWindow";
            this.Text = "CitySelectionWindow";
            this.groupBoxCitySelection.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLocationList;
        private System.Windows.Forms.GroupBox groupBoxCitySelection;
        private System.Windows.Forms.Button buttonApply;
    }
}