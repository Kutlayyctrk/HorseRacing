namespace HorseRacing
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
            this.cmbJockey = new System.Windows.Forms.ComboBox();
            this.TxtHorseName = new System.Windows.Forms.TextBox();
            this.TxtHorseAge = new System.Windows.Forms.TextBox();
            this.TxtHorseRegion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnRace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbJockey
            // 
            this.cmbJockey.FormattingEnabled = true;
            this.cmbJockey.Location = new System.Drawing.Point(123, 236);
            this.cmbJockey.Name = "cmbJockey";
            this.cmbJockey.Size = new System.Drawing.Size(100, 24);
            this.cmbJockey.TabIndex = 0;
            // 
            // TxtHorseName
            // 
            this.TxtHorseName.Location = new System.Drawing.Point(123, 90);
            this.TxtHorseName.Name = "TxtHorseName";
            this.TxtHorseName.Size = new System.Drawing.Size(100, 22);
            this.TxtHorseName.TabIndex = 1;
            // 
            // TxtHorseAge
            // 
            this.TxtHorseAge.Location = new System.Drawing.Point(123, 135);
            this.TxtHorseAge.Name = "TxtHorseAge";
            this.TxtHorseAge.Size = new System.Drawing.Size(100, 22);
            this.TxtHorseAge.TabIndex = 1;
            // 
            // TxtHorseRegion
            // 
            this.TxtHorseRegion.Location = new System.Drawing.Point(123, 186);
            this.TxtHorseRegion.Name = "TxtHorseRegion";
            this.TxtHorseRegion.Size = new System.Drawing.Size(100, 22);
            this.TxtHorseRegion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "At Adı Gir:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "At Yarış Gir:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "At Irkı Gir:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Jokey Seçin";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "At Oluştur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnRace
            // 
            this.BtnRace.Location = new System.Drawing.Point(305, 289);
            this.BtnRace.Name = "BtnRace";
            this.BtnRace.Size = new System.Drawing.Size(121, 48);
            this.BtnRace.TabIndex = 4;
            this.BtnRace.Text = "Koşu Oluşturma Ekranı";
            this.BtnRace.UseVisualStyleBackColor = true;
            this.BtnRace.Click += new System.EventHandler(this.BtnRace_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 406);
            this.Controls.Add(this.BtnRace);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtHorseRegion);
            this.Controls.Add(this.TxtHorseAge);
            this.Controls.Add(this.TxtHorseName);
            this.Controls.Add(this.cmbJockey);
            this.Name = "Form2";
            this.Text = "At Oluştur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbJockey;
        private System.Windows.Forms.TextBox TxtHorseName;
        private System.Windows.Forms.TextBox TxtHorseAge;
        private System.Windows.Forms.TextBox TxtHorseRegion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnRace;
    }
}