namespace HorseRacing
{
    partial class FrmMain
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
            this.BtnCreateJockey = new System.Windows.Forms.Button();
            this.BtnCreateRaceCard = new System.Windows.Forms.Button();
            this.BtnCreateHorse = new System.Windows.Forms.Button();
            this.BtnCreateRace = new System.Windows.Forms.Button();
            this.BtnCreateRaceDay = new System.Windows.Forms.Button();
            this.BtnInformation = new System.Windows.Forms.Button();
            this.LblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCreateJockey
            // 
            this.BtnCreateJockey.Location = new System.Drawing.Point(34, 60);
            this.BtnCreateJockey.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCreateJockey.Name = "BtnCreateJockey";
            this.BtnCreateJockey.Size = new System.Drawing.Size(103, 53);
            this.BtnCreateJockey.TabIndex = 0;
            this.BtnCreateJockey.Text = "Jokey Oluştur";
            this.BtnCreateJockey.UseVisualStyleBackColor = true;
            this.BtnCreateJockey.Click += new System.EventHandler(this.BtnCreateJockey_Click);
            // 
            // BtnCreateRaceCard
            // 
            this.BtnCreateRaceCard.Location = new System.Drawing.Point(392, 60);
            this.BtnCreateRaceCard.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCreateRaceCard.Name = "BtnCreateRaceCard";
            this.BtnCreateRaceCard.Size = new System.Drawing.Size(103, 53);
            this.BtnCreateRaceCard.TabIndex = 0;
            this.BtnCreateRaceCard.Text = "Bülten Oluştur";
            this.BtnCreateRaceCard.UseVisualStyleBackColor = true;
            this.BtnCreateRaceCard.Click += new System.EventHandler(this.BtnCreateRaceCard_Click);
            // 
            // BtnCreateHorse
            // 
            this.BtnCreateHorse.Location = new System.Drawing.Point(148, 60);
            this.BtnCreateHorse.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCreateHorse.Name = "BtnCreateHorse";
            this.BtnCreateHorse.Size = new System.Drawing.Size(103, 53);
            this.BtnCreateHorse.TabIndex = 0;
            this.BtnCreateHorse.Text = "At Oluştur";
            this.BtnCreateHorse.UseVisualStyleBackColor = true;
            this.BtnCreateHorse.Click += new System.EventHandler(this.BtnCreateHorse_Click);
            // 
            // BtnCreateRace
            // 
            this.BtnCreateRace.Location = new System.Drawing.Point(520, 60);
            this.BtnCreateRace.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCreateRace.Name = "BtnCreateRace";
            this.BtnCreateRace.Size = new System.Drawing.Size(103, 53);
            this.BtnCreateRace.TabIndex = 0;
            this.BtnCreateRace.Text = "Koşu Oluştur";
            this.BtnCreateRace.UseVisualStyleBackColor = true;
            this.BtnCreateRace.Click += new System.EventHandler(this.BtnCreateRace_Click);
            // 
            // BtnCreateRaceDay
            // 
            this.BtnCreateRaceDay.Location = new System.Drawing.Point(269, 60);
            this.BtnCreateRaceDay.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCreateRaceDay.Name = "BtnCreateRaceDay";
            this.BtnCreateRaceDay.Size = new System.Drawing.Size(103, 53);
            this.BtnCreateRaceDay.TabIndex = 0;
            this.BtnCreateRaceDay.Text = "Yarış Günü Oluştur";
            this.BtnCreateRaceDay.UseVisualStyleBackColor = true;
            this.BtnCreateRaceDay.Click += new System.EventHandler(this.BtnCreateRaceDay_Click);
            // 
            // BtnInformation
            // 
            this.BtnInformation.Location = new System.Drawing.Point(269, 129);
            this.BtnInformation.Margin = new System.Windows.Forms.Padding(2);
            this.BtnInformation.Name = "BtnInformation";
            this.BtnInformation.Size = new System.Drawing.Size(103, 53);
            this.BtnInformation.TabIndex = 1;
            this.BtnInformation.Text = "Bilgi Görüntüle";
            this.BtnInformation.UseVisualStyleBackColor = true;
            this.BtnInformation.Click += new System.EventHandler(this.BtnInformation_Click);
            // 
            // LblInfo
            // 
            this.LblInfo.BackColor = System.Drawing.SystemColors.Info;
            this.LblInfo.Location = new System.Drawing.Point(46, 191);
            this.LblInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(400, 68);
            this.LblInfo.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 287);
            this.Controls.Add(this.LblInfo);
            this.Controls.Add(this.BtnInformation);
            this.Controls.Add(this.BtnCreateRace);
            this.Controls.Add(this.BtnCreateRaceDay);
            this.Controls.Add(this.BtnCreateRaceCard);
            this.Controls.Add(this.BtnCreateHorse);
            this.Controls.Add(this.BtnCreateJockey);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCreateJockey;
        private System.Windows.Forms.Button BtnCreateRaceCard;
        private System.Windows.Forms.Button BtnCreateHorse;
        private System.Windows.Forms.Button BtnCreateRace;
        private System.Windows.Forms.Button BtnCreateRaceDay;
        private System.Windows.Forms.Button BtnInformation;
        private System.Windows.Forms.Label LblInfo;
    }
}