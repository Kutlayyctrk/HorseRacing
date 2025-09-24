namespace HorseRacing
{
    partial class FrmCreateHorse
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
            this.TxtHorseName = new System.Windows.Forms.TextBox();
            this.TxtHorsaAge = new System.Windows.Forms.TextBox();
            this.TxtHorseRegion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCreateHorse = new System.Windows.Forms.Button();
            this.CmbJockey = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtHorseName
            // 
            this.TxtHorseName.Location = new System.Drawing.Point(102, 43);
            this.TxtHorseName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtHorseName.Name = "TxtHorseName";
            this.TxtHorseName.Size = new System.Drawing.Size(76, 20);
            this.TxtHorseName.TabIndex = 0;
            // 
            // TxtHorsaAge
            // 
            this.TxtHorsaAge.Location = new System.Drawing.Point(102, 89);
            this.TxtHorsaAge.Margin = new System.Windows.Forms.Padding(2);
            this.TxtHorsaAge.Name = "TxtHorsaAge";
            this.TxtHorsaAge.Size = new System.Drawing.Size(76, 20);
            this.TxtHorsaAge.TabIndex = 1;
            // 
            // TxtHorseRegion
            // 
            this.TxtHorseRegion.Location = new System.Drawing.Point(102, 136);
            this.TxtHorseRegion.Margin = new System.Windows.Forms.Padding(2);
            this.TxtHorseRegion.Name = "TxtHorseRegion";
            this.TxtHorseRegion.Size = new System.Drawing.Size(76, 20);
            this.TxtHorseRegion.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "At İsmi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Atın Yaşı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Atın Irkı:";
            // 
            // BtnCreateHorse
            // 
            this.BtnCreateHorse.Location = new System.Drawing.Point(110, 206);
            this.BtnCreateHorse.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCreateHorse.Name = "BtnCreateHorse";
            this.BtnCreateHorse.Size = new System.Drawing.Size(67, 28);
            this.BtnCreateHorse.TabIndex = 4;
            this.BtnCreateHorse.Text = "At Oluştur";
            this.BtnCreateHorse.UseVisualStyleBackColor = true;
            this.BtnCreateHorse.Click += new System.EventHandler(this.BtnCreateHorse_Click);
            // 
            // CmbJockey
            // 
            this.CmbJockey.FormattingEnabled = true;
            this.CmbJockey.Location = new System.Drawing.Point(102, 171);
            this.CmbJockey.Margin = new System.Windows.Forms.Padding(2);
            this.CmbJockey.Name = "CmbJockey";
            this.CmbJockey.Size = new System.Drawing.Size(76, 21);
            this.CmbJockey.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Jockey Seçin:";
            // 
            // FrmCreateHorse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.CmbJockey);
            this.Controls.Add(this.BtnCreateHorse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtHorseRegion);
            this.Controls.Add(this.TxtHorsaAge);
            this.Controls.Add(this.TxtHorseName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCreateHorse";
            this.Text = "CreateHorse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtHorseName;
        private System.Windows.Forms.TextBox TxtHorsaAge;
        private System.Windows.Forms.TextBox TxtHorseRegion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCreateHorse;
        private System.Windows.Forms.ComboBox CmbJockey;
        private System.Windows.Forms.Label label4;
    }
}