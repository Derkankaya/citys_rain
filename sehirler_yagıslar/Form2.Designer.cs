namespace sehirler_yagıslar
{
    partial class Form2
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
            this.cityButton = new System.Windows.Forms.Button();
            this.rainButton = new System.Windows.Forms.Button();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblRain = new System.Windows.Forms.Label();
            this.txtRainAmont = new System.Windows.Forms.TextBox();
            this.saveRainAmountButton = new System.Windows.Forms.Button();
            this.ComboMounth = new System.Windows.Forms.ComboBox();
            this.ComboCity = new System.Windows.Forms.ComboBox();
            this.ComboYear = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.refleshButton = new System.Windows.Forms.Button();
            this.chartButton = new System.Windows.Forms.Button();
            this.tableButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cityButton
            // 
            this.cityButton.Location = new System.Drawing.Point(26, 21);
            this.cityButton.Name = "cityButton";
            this.cityButton.Size = new System.Drawing.Size(114, 46);
            this.cityButton.TabIndex = 0;
            this.cityButton.TabStop = false;
            this.cityButton.Text = "Sehirler";
            this.cityButton.UseVisualStyleBackColor = true;
            this.cityButton.Click += new System.EventHandler(this.cityButton_Click);
            // 
            // rainButton
            // 
            this.rainButton.Location = new System.Drawing.Point(164, 21);
            this.rainButton.Name = "rainButton";
            this.rainButton.Size = new System.Drawing.Size(114, 46);
            this.rainButton.TabIndex = 0;
            this.rainButton.Text = "Yağışlar";
            this.rainButton.UseVisualStyleBackColor = true;
            this.rainButton.Click += new System.EventHandler(this.cityButton_Click);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(39, 90);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(19, 16);
            this.lblCity.TabIndex = 1;
            this.lblCity.Text = "İl :";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(39, 127);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(31, 16);
            this.lblYear.TabIndex = 1;
            this.lblYear.Text = "Yıl : ";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(39, 162);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(29, 16);
            this.lblMonth.TabIndex = 1;
            this.lblMonth.Text = "Ay :";
            // 
            // lblRain
            // 
            this.lblRain.AutoSize = true;
            this.lblRain.Location = new System.Drawing.Point(39, 195);
            this.lblRain.Name = "lblRain";
            this.lblRain.Size = new System.Drawing.Size(42, 16);
            this.lblRain.TabIndex = 1;
            this.lblRain.Text = "Yağış";
            // 
            // txtRainAmont
            // 
            this.txtRainAmont.Location = new System.Drawing.Point(107, 188);
            this.txtRainAmont.Name = "txtRainAmont";
            this.txtRainAmont.Size = new System.Drawing.Size(212, 22);
            this.txtRainAmont.TabIndex = 3;
            // 
            // saveRainAmountButton
            // 
            this.saveRainAmountButton.Location = new System.Drawing.Point(359, 167);
            this.saveRainAmountButton.Name = "saveRainAmountButton";
            this.saveRainAmountButton.Size = new System.Drawing.Size(106, 44);
            this.saveRainAmountButton.TabIndex = 4;
            this.saveRainAmountButton.Text = "Kaydet";
            this.saveRainAmountButton.UseVisualStyleBackColor = true;
            this.saveRainAmountButton.Click += new System.EventHandler(this.saveRainAmountButton_Click);
            // 
            // ComboMounth
            // 
            this.ComboMounth.FormattingEnabled = true;
            this.ComboMounth.Location = new System.Drawing.Point(107, 154);
            this.ComboMounth.Name = "ComboMounth";
            this.ComboMounth.Size = new System.Drawing.Size(212, 24);
            this.ComboMounth.TabIndex = 2;
            // 
            // ComboCity
            // 
            this.ComboCity.FormattingEnabled = true;
            this.ComboCity.Location = new System.Drawing.Point(107, 87);
            this.ComboCity.Name = "ComboCity";
            this.ComboCity.Size = new System.Drawing.Size(212, 24);
            this.ComboCity.TabIndex = 2;
            // 
            // ComboYear
            // 
            this.ComboYear.FormattingEnabled = true;
            this.ComboYear.Location = new System.Drawing.Point(107, 124);
            this.ComboYear.Name = "ComboYear";
            this.ComboYear.Size = new System.Drawing.Size(212, 24);
            this.ComboYear.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(762, 205);
            this.dataGridView1.TabIndex = 5;
            // 
            // refleshButton
            // 
            this.refleshButton.Location = new System.Drawing.Point(587, 166);
            this.refleshButton.Name = "refleshButton";
            this.refleshButton.Size = new System.Drawing.Size(166, 45);
            this.refleshButton.TabIndex = 6;
            this.refleshButton.Text = "Yenile";
            this.refleshButton.UseVisualStyleBackColor = true;
            this.refleshButton.Click += new System.EventHandler(this.refleshButton_Click);
            // 
            // chartButton
            // 
            this.chartButton.Location = new System.Drawing.Point(299, 21);
            this.chartButton.Name = "chartButton";
            this.chartButton.Size = new System.Drawing.Size(114, 46);
            this.chartButton.TabIndex = 7;
            this.chartButton.Text = "Grafik";
            this.chartButton.UseVisualStyleBackColor = true;
            this.chartButton.Click += new System.EventHandler(this.chartButton_Click);
            // 
            // tableButton
            // 
            this.tableButton.Location = new System.Drawing.Point(436, 21);
            this.tableButton.Name = "tableButton";
            this.tableButton.Size = new System.Drawing.Size(114, 46);
            this.tableButton.TabIndex = 7;
            this.tableButton.Text = "Tablo";
            this.tableButton.UseVisualStyleBackColor = true;
            this.tableButton.Click += new System.EventHandler(this.tableButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableButton);
            this.Controls.Add(this.chartButton);
            this.Controls.Add(this.refleshButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.saveRainAmountButton);
            this.Controls.Add(this.txtRainAmont);
            this.Controls.Add(this.ComboMounth);
            this.Controls.Add(this.ComboYear);
            this.Controls.Add(this.ComboCity);
            this.Controls.Add(this.lblRain);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.rainButton);
            this.Controls.Add(this.cityButton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cityButton;
        private System.Windows.Forms.Button rainButton;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblRain;
        private System.Windows.Forms.TextBox txtRainAmont;
        private System.Windows.Forms.Button saveRainAmountButton;
        private System.Windows.Forms.ComboBox ComboMounth;
        private System.Windows.Forms.ComboBox ComboCity;
        private System.Windows.Forms.ComboBox ComboYear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button refleshButton;
        private System.Windows.Forms.Button chartButton;
        private System.Windows.Forms.Button tableButton;
    }
}