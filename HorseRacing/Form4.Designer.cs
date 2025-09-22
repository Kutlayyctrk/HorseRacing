namespace HorseRacing
{
    partial class Form4
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
            this.cmbRace = new System.Windows.Forms.ComboBox();
            this.TxtRaceCardPlace = new System.Windows.Forms.TextBox();
            this.TxtRaceCardName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnRaceCard = new System.Windows.Forms.Button();
            this.BtnRaceDay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbRace
            // 
            this.cmbRace.FormattingEnabled = true;
            this.cmbRace.Location = new System.Drawing.Point(121, 182);
            this.cmbRace.Name = "cmbRace";
            this.cmbRace.Size = new System.Drawing.Size(121, 24);
            this.cmbRace.TabIndex = 0;
            // 
            // TxtRaceCardPlace
            // 
            this.TxtRaceCardPlace.Location = new System.Drawing.Point(121, 124);
            this.TxtRaceCardPlace.Name = "TxtRaceCardPlace";
            this.TxtRaceCardPlace.Size = new System.Drawing.Size(121, 22);
            this.TxtRaceCardPlace.TabIndex = 1;
            // 
            // TxtRaceCardName
            // 
            this.TxtRaceCardName.Location = new System.Drawing.Point(121, 66);
            this.TxtRaceCardName.Name = "TxtRaceCardName";
            this.TxtRaceCardName.Size = new System.Drawing.Size(121, 22);
            this.TxtRaceCardName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bülten Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bülten Şehri:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Koşu Seçimi:";
            // 
            // BtnRaceCard
            // 
            this.BtnRaceCard.Location = new System.Drawing.Point(121, 246);
            this.BtnRaceCard.Name = "BtnRaceCard";
            this.BtnRaceCard.Size = new System.Drawing.Size(121, 23);
            this.BtnRaceCard.TabIndex = 3;
            this.BtnRaceCard.Text = "Bülten Oluştur";
            this.BtnRaceCard.UseVisualStyleBackColor = true;
            this.BtnRaceCard.Click += new System.EventHandler(this.BtnRaceCard_Click);
            // 
            // BtnRaceDay
            // 
            this.BtnRaceDay.Location = new System.Drawing.Point(121, 296);
            this.BtnRaceDay.Name = "BtnRaceDay";
            this.BtnRaceDay.Size = new System.Drawing.Size(121, 48);
            this.BtnRaceDay.TabIndex = 4;
            this.BtnRaceDay.Text = "Bültenleri Görüntüle";
            this.BtnRaceDay.UseVisualStyleBackColor = true;
            this.BtnRaceDay.Click += new System.EventHandler(this.BtnRaceDay_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnRaceDay);
            this.Controls.Add(this.BtnRaceCard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtRaceCardName);
            this.Controls.Add(this.TxtRaceCardPlace);
            this.Controls.Add(this.cmbRace);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRace;
        private System.Windows.Forms.TextBox TxtRaceCardPlace;
        private System.Windows.Forms.TextBox TxtRaceCardName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnRaceCard;
        private System.Windows.Forms.Button BtnRaceDay;
    }
}