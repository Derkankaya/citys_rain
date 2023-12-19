namespace sehirler_yagıslar
{
    partial class Form4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.comboCity1 = new System.Windows.Forms.ComboBox();
            this.comboCity2 = new System.Windows.Forms.ComboBox();
            this.comboYear = new System.Windows.Forms.ComboBox();
            this.showButton = new System.Windows.Forms.Button();
            this.cityButton = new System.Windows.Forms.Button();
            this.rainButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboCity1
            // 
            this.comboCity1.FormattingEnabled = true;
            this.comboCity1.Location = new System.Drawing.Point(27, 335);
            this.comboCity1.Name = "comboCity1";
            this.comboCity1.Size = new System.Drawing.Size(179, 24);
            this.comboCity1.TabIndex = 0;
            // 
            // comboCity2
            // 
            this.comboCity2.FormattingEnabled = true;
            this.comboCity2.Location = new System.Drawing.Point(27, 387);
            this.comboCity2.Name = "comboCity2";
            this.comboCity2.Size = new System.Drawing.Size(179, 24);
            this.comboCity2.TabIndex = 0;
            // 
            // comboYear
            // 
            this.comboYear.FormattingEnabled = true;
            this.comboYear.Location = new System.Drawing.Point(243, 335);
            this.comboYear.Name = "comboYear";
            this.comboYear.Size = new System.Drawing.Size(179, 24);
            this.comboYear.TabIndex = 0;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(240, 372);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(182, 39);
            this.showButton.TabIndex = 1;
            this.showButton.Text = "Göster";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // cityButton
            // 
            this.cityButton.Location = new System.Drawing.Point(550, 335);
            this.cityButton.Name = "cityButton";
            this.cityButton.Size = new System.Drawing.Size(182, 39);
            this.cityButton.TabIndex = 1;
            this.cityButton.Text = "Şehirler";
            this.cityButton.UseVisualStyleBackColor = true;
            this.cityButton.Click += new System.EventHandler(this.cityButton_Click);
            // 
            // rainButton
            // 
            this.rainButton.Location = new System.Drawing.Point(550, 387);
            this.rainButton.Name = "rainButton";
            this.rainButton.Size = new System.Drawing.Size(182, 39);
            this.rainButton.TabIndex = 1;
            this.rainButton.Text = "Yağışlar";
            this.rainButton.UseVisualStyleBackColor = true;
            this.rainButton.Click += new System.EventHandler(this.rainButton_Click);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(27, 12);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(761, 300);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.rainButton);
            this.Controls.Add(this.cityButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.comboYear);
            this.Controls.Add(this.comboCity2);
            this.Controls.Add(this.comboCity1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboCity1;
        private System.Windows.Forms.ComboBox comboCity2;
        private System.Windows.Forms.ComboBox comboYear;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button cityButton;
        private System.Windows.Forms.Button rainButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}