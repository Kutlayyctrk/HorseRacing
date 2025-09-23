namespace HorseRacing
{
    partial class MainForm
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
            this.SuspendLayout();
            // 
            // BtnCreateJockey
            // 
            this.BtnCreateJockey.Location = new System.Drawing.Point(152, 60);
            this.BtnCreateJockey.Name = "BtnCreateJockey";
            this.BtnCreateJockey.Size = new System.Drawing.Size(137, 65);
            this.BtnCreateJockey.TabIndex = 0;
            this.BtnCreateJockey.Text = "Jokey Oluştur";
            this.BtnCreateJockey.UseVisualStyleBackColor = true;
            this.BtnCreateJockey.Click += new System.EventHandler(this.BtnCreateJockey_Click);
            // 
            // BtnCreateRaceCard
            // 
            this.BtnCreateRaceCard.Location = new System.Drawing.Point(581, 60);
            this.BtnCreateRaceCard.Name = "BtnCreateRaceCard";
            this.BtnCreateRaceCard.Size = new System.Drawing.Size(137, 65);
            this.BtnCreateRaceCard.TabIndex = 0;
            this.BtnCreateRaceCard.Text = "Bülten Oluştur";
            this.BtnCreateRaceCard.UseVisualStyleBackColor = true;
            this.BtnCreateRaceCard.Click += new System.EventHandler(this.BtnCreateRaceCard_Click);
            // 
            // BtnCreateHorse
            // 
            this.BtnCreateHorse.Location = new System.Drawing.Point(295, 60);
            this.BtnCreateHorse.Name = "BtnCreateHorse";
            this.BtnCreateHorse.Size = new System.Drawing.Size(137, 65);
            this.BtnCreateHorse.TabIndex = 0;
            this.BtnCreateHorse.Text = "At Oluştur";
            this.BtnCreateHorse.UseVisualStyleBackColor = true;
            this.BtnCreateHorse.Click += new System.EventHandler(this.BtnCreateHorse_Click);
            // 
            // BtnCreateRace
            // 
            this.BtnCreateRace.Location = new System.Drawing.Point(438, 60);
            this.BtnCreateRace.Name = "BtnCreateRace";
            this.BtnCreateRace.Size = new System.Drawing.Size(137, 65);
            this.BtnCreateRace.TabIndex = 0;
            this.BtnCreateRace.Text = "Koşu Oluştur";
            this.BtnCreateRace.UseVisualStyleBackColor = true;
            this.BtnCreateRace.Click += new System.EventHandler(this.BtnCreateRace_Click);
            // 
            // BtnCreateRaceDay
            // 
            this.BtnCreateRaceDay.Location = new System.Drawing.Point(724, 60);
            this.BtnCreateRaceDay.Name = "BtnCreateRaceDay";
            this.BtnCreateRaceDay.Size = new System.Drawing.Size(137, 65);
            this.BtnCreateRaceDay.TabIndex = 0;
            this.BtnCreateRaceDay.Text = "Yarış Günü Oluştur";
            this.BtnCreateRaceDay.UseVisualStyleBackColor = true;
            this.BtnCreateRaceDay.Click += new System.EventHandler(this.BtnCreateRaceDay_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 655);
            this.Controls.Add(this.BtnCreateRace);
            this.Controls.Add(this.BtnCreateRaceDay);
            this.Controls.Add(this.BtnCreateRaceCard);
            this.Controls.Add(this.BtnCreateHorse);
            this.Controls.Add(this.BtnCreateJockey);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCreateJockey;
        private System.Windows.Forms.Button BtnCreateRaceCard;
        private System.Windows.Forms.Button BtnCreateHorse;
        private System.Windows.Forms.Button BtnCreateRace;
        private System.Windows.Forms.Button BtnCreateRaceDay;
    }
}