namespace HorseRacing
{
    partial class Form3
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
            this.CmbHorse = new System.Windows.Forms.ComboBox();
            this.TxtRaceName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnRace = new System.Windows.Forms.Button();
            this.BtnHorse = new System.Windows.Forms.Button();
            this.LstSelectedHorse = new System.Windows.Forms.ListBox();
            this.BtnRaceCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmbHorse
            // 
            this.CmbHorse.FormattingEnabled = true;
            this.CmbHorse.Location = new System.Drawing.Point(135, 131);
            this.CmbHorse.Name = "CmbHorse";
            this.CmbHorse.Size = new System.Drawing.Size(121, 24);
            this.CmbHorse.TabIndex = 0;
            // 
            // TxtRaceName
            // 
            this.TxtRaceName.Location = new System.Drawing.Point(135, 77);
            this.TxtRaceName.Name = "TxtRaceName";
            this.TxtRaceName.Size = new System.Drawing.Size(121, 22);
            this.TxtRaceName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Koşu No Gir:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Atları Seç:";
            // 
            // BtnRace
            // 
            this.BtnRace.Location = new System.Drawing.Point(135, 234);
            this.BtnRace.Name = "BtnRace";
            this.BtnRace.Size = new System.Drawing.Size(121, 25);
            this.BtnRace.TabIndex = 3;
            this.BtnRace.Text = "Koşu Oluştur";
            this.BtnRace.UseVisualStyleBackColor = true;
            this.BtnRace.Click += new System.EventHandler(this.BtnRace_Click);
            // 
            // BtnHorse
            // 
            this.BtnHorse.Location = new System.Drawing.Point(135, 190);
            this.BtnHorse.Name = "BtnHorse";
            this.BtnHorse.Size = new System.Drawing.Size(121, 25);
            this.BtnHorse.TabIndex = 4;
            this.BtnHorse.Text = "At Ekle";
            this.BtnHorse.UseVisualStyleBackColor = true;
            this.BtnHorse.Click += new System.EventHandler(this.BtnHorse_Click);
            // 
            // LstSelectedHorse
            // 
            this.LstSelectedHorse.FormattingEnabled = true;
            this.LstSelectedHorse.ItemHeight = 16;
            this.LstSelectedHorse.Location = new System.Drawing.Point(457, 79);
            this.LstSelectedHorse.Name = "LstSelectedHorse";
            this.LstSelectedHorse.Size = new System.Drawing.Size(262, 260);
            this.LstSelectedHorse.TabIndex = 5;
            // 
            // BtnRaceCard
            // 
            this.BtnRaceCard.Location = new System.Drawing.Point(287, 190);
            this.BtnRaceCard.Name = "BtnRaceCard";
            this.BtnRaceCard.Size = new System.Drawing.Size(120, 69);
            this.BtnRaceCard.TabIndex = 6;
            this.BtnRaceCard.Text = "Bülten Oluştur";
            this.BtnRaceCard.UseVisualStyleBackColor = true;
            this.BtnRaceCard.Click += new System.EventHandler(this.BtnRaceCard_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnRaceCard);
            this.Controls.Add(this.LstSelectedHorse);
            this.Controls.Add(this.BtnHorse);
            this.Controls.Add(this.BtnRace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtRaceName);
            this.Controls.Add(this.CmbHorse);
            this.Name = "Form3";
            this.Text = "Koşu Oluştur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbHorse;
        private System.Windows.Forms.TextBox TxtRaceName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnRace;
        private System.Windows.Forms.Button BtnHorse;
        private System.Windows.Forms.ListBox LstSelectedHorse;
        private System.Windows.Forms.Button BtnRaceCard;
    }
}