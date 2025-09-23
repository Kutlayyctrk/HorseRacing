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
            this.label1 = new System.Windows.Forms.Label();
            this.CmbRaceDays = new System.Windows.Forms.ComboBox();
            this.CmbRaces = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnCreateRaceCard = new System.Windows.Forms.Button();
            this.BtnAddRace = new System.Windows.Forms.Button();
            this.LstSelectedRace = new System.Windows.Forms.ListBox();
            this.BtnRemoveRace = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Koşular";
            // 
            // CmbRaceDays
            // 
            this.CmbRaceDays.FormattingEnabled = true;
            this.CmbRaceDays.Location = new System.Drawing.Point(155, 198);
            this.CmbRaceDays.Name = "CmbRaceDays";
            this.CmbRaceDays.Size = new System.Drawing.Size(100, 24);
            this.CmbRaceDays.TabIndex = 2;
            // 
            // CmbRaces
            // 
            this.CmbRaces.FormattingEnabled = true;
            this.CmbRaces.Location = new System.Drawing.Point(155, 156);
            this.CmbRaces.Name = "CmbRaces";
            this.CmbRaces.Size = new System.Drawing.Size(100, 24);
            this.CmbRaces.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 203);
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
            this.BtnCreateRaceCard.Location = new System.Drawing.Point(155, 258);
            this.BtnCreateRaceCard.Name = "BtnCreateRaceCard";
            this.BtnCreateRaceCard.Size = new System.Drawing.Size(100, 23);
            this.BtnCreateRaceCard.TabIndex = 3;
            this.BtnCreateRaceCard.Text = "Bülten Oluştur";
            this.BtnCreateRaceCard.UseVisualStyleBackColor = true;
            this.BtnCreateRaceCard.Click += new System.EventHandler(this.BtnCreateRaceCard_Click);
            // 
            // BtnAddRace
            // 
            this.BtnAddRace.Location = new System.Drawing.Point(293, 135);
            this.BtnAddRace.Name = "BtnAddRace";
            this.BtnAddRace.Size = new System.Drawing.Size(123, 68);
            this.BtnAddRace.TabIndex = 4;
            this.BtnAddRace.Text = "Koşu Grubuna Ekle";
            this.BtnAddRace.UseVisualStyleBackColor = true;
            this.BtnAddRace.Click += new System.EventHandler(this.BtnAddRace_Click);
            // 
            // LstSelectedRace
            // 
            this.LstSelectedRace.FormattingEnabled = true;
            this.LstSelectedRace.ItemHeight = 16;
            this.LstSelectedRace.Location = new System.Drawing.Point(422, 74);
            this.LstSelectedRace.Name = "LstSelectedRace";
            this.LstSelectedRace.Size = new System.Drawing.Size(272, 132);
            this.LstSelectedRace.TabIndex = 5;
            // 
            // BtnRemoveRace
            // 
            this.BtnRemoveRace.Location = new System.Drawing.Point(571, 231);
            this.BtnRemoveRace.Name = "BtnRemoveRace";
            this.BtnRemoveRace.Size = new System.Drawing.Size(123, 68);
            this.BtnRemoveRace.TabIndex = 4;
            this.BtnRemoveRace.Text = "Koşu Grubundan Çıkar";
            this.BtnRemoveRace.UseVisualStyleBackColor = true;
            this.BtnRemoveRace.Click += new System.EventHandler(this.BtnRemoveRace_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(261, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "=>";
            // 
            // CreateRaceCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LstSelectedRace);
            this.Controls.Add(this.BtnRemoveRace);
            this.Controls.Add(this.BtnAddRace);
            this.Controls.Add(this.BtnCreateRaceCard);
            this.Controls.Add(this.CmbRaces);
            this.Controls.Add(this.CmbRaceDays);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbRaceDays;
        private System.Windows.Forms.ComboBox CmbRaces;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnCreateRaceCard;
        private System.Windows.Forms.Button BtnAddRace;
        private System.Windows.Forms.ListBox LstSelectedRace;
        private System.Windows.Forms.Button BtnRemoveRace;
        private System.Windows.Forms.Label label5;
    }
}