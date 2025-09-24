namespace HorseRacing
{
    partial class FrmCreateRace
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
            this.TxtRaceName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbHorse = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbRaceCard = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCreateRace = new System.Windows.Forms.Button();
            this.BtnAddHorse = new System.Windows.Forms.Button();
            this.LstSelectedHorse = new System.Windows.Forms.ListBox();
            this.BtnDeleteHorse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtRaceName
            // 
            this.TxtRaceName.Location = new System.Drawing.Point(139, 44);
            this.TxtRaceName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtRaceName.Name = "TxtRaceName";
            this.TxtRaceName.Size = new System.Drawing.Size(100, 22);
            this.TxtRaceName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // CmbHorse
            // 
            this.CmbHorse.FormattingEnabled = true;
            this.CmbHorse.Location = new System.Drawing.Point(139, 112);
            this.CmbHorse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbHorse.Name = "CmbHorse";
            this.CmbHorse.Size = new System.Drawing.Size(100, 24);
            this.CmbHorse.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose Horse";
            // 
            // CmbRaceCard
            // 
            this.CmbRaceCard.FormattingEnabled = true;
            this.CmbRaceCard.Location = new System.Drawing.Point(139, 175);
            this.CmbRaceCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbRaceCard.Name = "CmbRaceCard";
            this.CmbRaceCard.Size = new System.Drawing.Size(100, 24);
            this.CmbRaceCard.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Choose Bulletin";
            // 
            // BtnCreateRace
            // 
            this.BtnCreateRace.Location = new System.Drawing.Point(148, 263);
            this.BtnCreateRace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCreateRace.Name = "BtnCreateRace";
            this.BtnCreateRace.Size = new System.Drawing.Size(100, 37);
            this.BtnCreateRace.TabIndex = 3;
            this.BtnCreateRace.Text = "Add Race";
            this.BtnCreateRace.UseVisualStyleBackColor = true;
            this.BtnCreateRace.Click += new System.EventHandler(this.BtnCreateRace_Click);
            // 
            // BtnAddHorse
            // 
            this.BtnAddHorse.Location = new System.Drawing.Point(269, 107);
            this.BtnAddHorse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAddHorse.Name = "BtnAddHorse";
            this.BtnAddHorse.Size = new System.Drawing.Size(138, 48);
            this.BtnAddHorse.TabIndex = 4;
            this.BtnAddHorse.Text = "Add Horse To The Group";
            this.BtnAddHorse.UseVisualStyleBackColor = true;
            this.BtnAddHorse.Click += new System.EventHandler(this.BtnAddHorse_Click);
            // 
            // LstSelectedHorse
            // 
            this.LstSelectedHorse.FormattingEnabled = true;
            this.LstSelectedHorse.ItemHeight = 16;
            this.LstSelectedHorse.Location = new System.Drawing.Point(429, 66);
            this.LstSelectedHorse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LstSelectedHorse.Name = "LstSelectedHorse";
            this.LstSelectedHorse.Size = new System.Drawing.Size(348, 132);
            this.LstSelectedHorse.TabIndex = 5;
            // 
            // BtnDeleteHorse
            // 
            this.BtnDeleteHorse.Location = new System.Drawing.Point(648, 215);
            this.BtnDeleteHorse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDeleteHorse.Name = "BtnDeleteHorse";
            this.BtnDeleteHorse.Size = new System.Drawing.Size(129, 55);
            this.BtnDeleteHorse.TabIndex = 4;
            this.BtnDeleteHorse.Text = "Remove Horse From The Group";
            this.BtnDeleteHorse.UseVisualStyleBackColor = true;
            this.BtnDeleteHorse.Click += new System.EventHandler(this.BtnDeleteHorse_Click);
            // 
            // FrmCreateRace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LstSelectedHorse);
            this.Controls.Add(this.BtnDeleteHorse);
            this.Controls.Add(this.BtnAddHorse);
            this.Controls.Add(this.BtnCreateRace);
            this.Controls.Add(this.CmbRaceCard);
            this.Controls.Add(this.CmbHorse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtRaceName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmCreateRace";
            this.Text = "Races";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtRaceName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbHorse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbRaceCard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCreateRace;
        private System.Windows.Forms.Button BtnAddHorse;
        private System.Windows.Forms.ListBox LstSelectedHorse;
        private System.Windows.Forms.Button BtnDeleteHorse;
    }
}