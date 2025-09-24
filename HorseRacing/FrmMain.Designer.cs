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
            this.BtnCreateJockey.Location = new System.Drawing.Point(45, 74);
            this.BtnCreateJockey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCreateJockey.Name = "BtnCreateJockey";
            this.BtnCreateJockey.Size = new System.Drawing.Size(137, 65);
            this.BtnCreateJockey.TabIndex = 0;
            this.BtnCreateJockey.Text = "Add Jokey";
            this.BtnCreateJockey.UseVisualStyleBackColor = true;
            this.BtnCreateJockey.Click += new System.EventHandler(this.BtnCreateJockey_Click);
            // 
            // BtnCreateRaceCard
            // 
            this.BtnCreateRaceCard.Location = new System.Drawing.Point(523, 74);
            this.BtnCreateRaceCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCreateRaceCard.Name = "BtnCreateRaceCard";
            this.BtnCreateRaceCard.Size = new System.Drawing.Size(137, 65);
            this.BtnCreateRaceCard.TabIndex = 0;
            this.BtnCreateRaceCard.Text = "Add Bulletin";
            this.BtnCreateRaceCard.UseVisualStyleBackColor = true;
            this.BtnCreateRaceCard.Click += new System.EventHandler(this.BtnCreateRaceCard_Click);
            // 
            // BtnCreateHorse
            // 
            this.BtnCreateHorse.Location = new System.Drawing.Point(197, 74);
            this.BtnCreateHorse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCreateHorse.Name = "BtnCreateHorse";
            this.BtnCreateHorse.Size = new System.Drawing.Size(137, 65);
            this.BtnCreateHorse.TabIndex = 0;
            this.BtnCreateHorse.Text = "Add Horse";
            this.BtnCreateHorse.UseVisualStyleBackColor = true;
            this.BtnCreateHorse.Click += new System.EventHandler(this.BtnCreateHorse_Click);
            // 
            // BtnCreateRace
            // 
            this.BtnCreateRace.Location = new System.Drawing.Point(693, 74);
            this.BtnCreateRace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCreateRace.Name = "BtnCreateRace";
            this.BtnCreateRace.Size = new System.Drawing.Size(137, 65);
            this.BtnCreateRace.TabIndex = 0;
            this.BtnCreateRace.Text = "Add Race";
            this.BtnCreateRace.UseVisualStyleBackColor = true;
            this.BtnCreateRace.Click += new System.EventHandler(this.BtnCreateRace_Click);
            // 
            // BtnCreateRaceDay
            // 
            this.BtnCreateRaceDay.Location = new System.Drawing.Point(359, 74);
            this.BtnCreateRaceDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCreateRaceDay.Name = "BtnCreateRaceDay";
            this.BtnCreateRaceDay.Size = new System.Drawing.Size(137, 65);
            this.BtnCreateRaceDay.TabIndex = 0;
            this.BtnCreateRaceDay.Text = "Add Race Day";
            this.BtnCreateRaceDay.UseVisualStyleBackColor = true;
            this.BtnCreateRaceDay.Click += new System.EventHandler(this.BtnCreateRaceDay_Click);
            // 
            // BtnInformation
            // 
            this.BtnInformation.Location = new System.Drawing.Point(359, 159);
            this.BtnInformation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnInformation.Name = "BtnInformation";
            this.BtnInformation.Size = new System.Drawing.Size(137, 65);
            this.BtnInformation.TabIndex = 1;
            this.BtnInformation.Text = "Show Info";
            this.BtnInformation.UseVisualStyleBackColor = true;
            this.BtnInformation.Click += new System.EventHandler(this.BtnInformation_Click);
            // 
            // LblInfo
            // 
            this.LblInfo.BackColor = System.Drawing.SystemColors.Info;
            this.LblInfo.Location = new System.Drawing.Point(61, 235);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(533, 84);
            this.LblInfo.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 353);
            this.Controls.Add(this.LblInfo);
            this.Controls.Add(this.BtnInformation);
            this.Controls.Add(this.BtnCreateRace);
            this.Controls.Add(this.BtnCreateRaceDay);
            this.Controls.Add(this.BtnCreateRaceCard);
            this.Controls.Add(this.BtnCreateHorse);
            this.Controls.Add(this.BtnCreateJockey);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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