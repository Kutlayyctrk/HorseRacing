namespace HorseRacing
{
    partial class CreateRaceCard
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
            this.TxtRaceCardName = new System.Windows.Forms.TextBox();
            this.TxtRaceCardPlace = new System.Windows.Forms.TextBox();
            this.CmbRaceDays = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnCreateRaceCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtRaceCardName
            // 
            this.TxtRaceCardName.Location = new System.Drawing.Point(155, 78);
            this.TxtRaceCardName.Name = "TxtRaceCardName";
            this.TxtRaceCardName.Size = new System.Drawing.Size(100, 22);
            this.TxtRaceCardName.TabIndex = 0;
            // 
            // TxtRaceCardPlace
            // 
            this.TxtRaceCardPlace.Location = new System.Drawing.Point(155, 118);
            this.TxtRaceCardPlace.Name = "TxtRaceCardPlace";
            this.TxtRaceCardPlace.Size = new System.Drawing.Size(100, 22);
            this.TxtRaceCardPlace.TabIndex = 0;
            // 
            // CmbRaceDays
            // 
            this.CmbRaceDays.FormattingEnabled = true;
            this.CmbRaceDays.Location = new System.Drawing.Point(155, 159);
            this.CmbRaceDays.Name = "CmbRaceDays";
            this.CmbRaceDays.Size = new System.Drawing.Size(100, 24);
            this.CmbRaceDays.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yarış Günü:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bülten Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Bülten Şehri:";
            // 
            // BtnCreateRaceCard
            // 
            this.BtnCreateRaceCard.Location = new System.Drawing.Point(155, 202);
            this.BtnCreateRaceCard.Name = "BtnCreateRaceCard";
            this.BtnCreateRaceCard.Size = new System.Drawing.Size(112, 41);
            this.BtnCreateRaceCard.TabIndex = 3;
            this.BtnCreateRaceCard.Text = "Bülten Oluştur";
            this.BtnCreateRaceCard.UseVisualStyleBackColor = true;
            this.BtnCreateRaceCard.Click += new System.EventHandler(this.BtnCreateRaceCard_Click);
            // 
            // CreateRaceCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCreateRaceCard);
            this.Controls.Add(this.CmbRaceDays);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtRaceCardPlace);
            this.Controls.Add(this.TxtRaceCardName);
            this.Name = "CreateRaceCard";
            this.Text = "CreateRaceCard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtRaceCardName;
        private System.Windows.Forms.TextBox TxtRaceCardPlace;
        private System.Windows.Forms.ComboBox CmbRaceDays;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnCreateRaceCard;
    }
}