namespace sehirler_yagıslar
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SehirAdi = new System.Windows.Forms.Label();
            this.txtCityName = new System.Windows.Forms.TextBox();
            this.SaveCityButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCityNo = new System.Windows.Forms.TextBox();
            this.refleshButton = new System.Windows.Forms.Button();
            this.SehirlerButton = new System.Windows.Forms.Button();
            this.YagisButton = new System.Windows.Forms.Button();
            this.GrafikButton = new System.Windows.Forms.Button();
            this.tableButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(746, 253);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SehirAdi
            // 
            this.SehirAdi.AutoSize = true;
            this.SehirAdi.Location = new System.Drawing.Point(28, 112);
            this.SehirAdi.Name = "SehirAdi";
            this.SehirAdi.Size = new System.Drawing.Size(67, 16);
            this.SehirAdi.TabIndex = 1;
            this.SehirAdi.Text = "Şehir Adı :";
            // 
            // txtCityName
            // 
            this.txtCityName.Location = new System.Drawing.Point(142, 109);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(171, 22);
            this.txtCityName.TabIndex = 2;
            // 
            // SaveCityButton
            // 
            this.SaveCityButton.Location = new System.Drawing.Point(339, 128);
            this.SaveCityButton.Name = "SaveCityButton";
            this.SaveCityButton.Size = new System.Drawing.Size(125, 35);
            this.SaveCityButton.TabIndex = 3;
            this.SaveCityButton.TabStop = false;
            this.SaveCityButton.Text = "Kaydet";
            this.SaveCityButton.UseVisualStyleBackColor = true;
            this.SaveCityButton.Click += new System.EventHandler(this.SaveCityButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Şehir Plaka  :";
            // 
            // txtCityNo
            // 
            this.txtCityNo.Location = new System.Drawing.Point(142, 141);
            this.txtCityNo.Name = "txtCityNo";
            this.txtCityNo.Size = new System.Drawing.Size(171, 22);
            this.txtCityNo.TabIndex = 2;
            // 
            // refleshButton
            // 
            this.refleshButton.Location = new System.Drawing.Point(514, 128);
            this.refleshButton.Name = "refleshButton";
            this.refleshButton.Size = new System.Drawing.Size(116, 35);
            this.refleshButton.TabIndex = 4;
            this.refleshButton.Text = "yenile";
            this.refleshButton.UseVisualStyleBackColor = true;
            this.refleshButton.Click += new System.EventHandler(this.refleshButton_Click);
            // 
            // SehirlerButton
            // 
            this.SehirlerButton.Location = new System.Drawing.Point(57, 31);
            this.SehirlerButton.Name = "SehirlerButton";
            this.SehirlerButton.Size = new System.Drawing.Size(133, 50);
            this.SehirlerButton.TabIndex = 5;
            this.SehirlerButton.Text = "Sehirler";
            this.SehirlerButton.UseVisualStyleBackColor = true;
            this.SehirlerButton.Click += new System.EventHandler(this.SehirlerButton_Click);
            // 
            // YagisButton
            // 
            this.YagisButton.Location = new System.Drawing.Point(196, 31);
            this.YagisButton.Name = "YagisButton";
            this.YagisButton.Size = new System.Drawing.Size(133, 50);
            this.YagisButton.TabIndex = 5;
            this.YagisButton.Text = "Yağış";
            this.YagisButton.UseVisualStyleBackColor = true;
            this.YagisButton.Click += new System.EventHandler(this.YagisButton_Click);
            // 
            // GrafikButton
            // 
            this.GrafikButton.Location = new System.Drawing.Point(339, 31);
            this.GrafikButton.Name = "GrafikButton";
            this.GrafikButton.Size = new System.Drawing.Size(147, 50);
            this.GrafikButton.TabIndex = 6;
            this.GrafikButton.Text = "Grafik";
            this.GrafikButton.UseVisualStyleBackColor = true;
            this.GrafikButton.Click += new System.EventHandler(this.GrafikButton_Click);
            // 
            // tableButton
            // 
            this.tableButton.Location = new System.Drawing.Point(492, 31);
            this.tableButton.Name = "tableButton";
            this.tableButton.Size = new System.Drawing.Size(147, 50);
            this.tableButton.TabIndex = 7;
            this.tableButton.Text = "Tablo";
            this.tableButton.UseVisualStyleBackColor = true;
            this.tableButton.Click += new System.EventHandler(this.tableButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableButton);
            this.Controls.Add(this.GrafikButton);
            this.Controls.Add(this.YagisButton);
            this.Controls.Add(this.SehirlerButton);
            this.Controls.Add(this.refleshButton);
            this.Controls.Add(this.SaveCityButton);
            this.Controls.Add(this.txtCityNo);
            this.Controls.Add(this.txtCityName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SehirAdi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label SehirAdi;
        private System.Windows.Forms.TextBox txtCityName;
        private System.Windows.Forms.Button SaveCityButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCityNo;
        private System.Windows.Forms.Button refleshButton;
        private System.Windows.Forms.Button SehirlerButton;
        private System.Windows.Forms.Button YagisButton;
        private System.Windows.Forms.Button GrafikButton;
        private System.Windows.Forms.Button tableButton;
    }
}

