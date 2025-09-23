namespace HorseRacing
{
    partial class CreateRaceDay
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
            this.TxtRaceDayName = new System.Windows.Forms.TextBox();
            this.DTPRaceDay = new System.Windows.Forms.DateTimePicker();
            this.CmbRaceCards = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCreateRaceDay = new System.Windows.Forms.Button();
            this.BtnAddRaceCard = new System.Windows.Forms.Button();
            this.BtnDeleteRaceCard = new System.Windows.Forms.Button();
            this.LstRaceCards = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TxtRaceDayName
            // 
            this.TxtRaceDayName.Location = new System.Drawing.Point(135, 113);
            this.TxtRaceDayName.Name = "TxtRaceDayName";
            this.TxtRaceDayName.Size = new System.Drawing.Size(100, 22);
            this.TxtRaceDayName.TabIndex = 0;
            // 
            // DTPRaceDay
            // 
            this.DTPRaceDay.Location = new System.Drawing.Point(135, 165);
            this.DTPRaceDay.Name = "DTPRaceDay";
            this.DTPRaceDay.Size = new System.Drawing.Size(197, 22);
            this.DTPRaceDay.TabIndex = 1;
            // 
            // CmbRaceCards
            // 
            this.CmbRaceCards.FormattingEnabled = true;
            this.CmbRaceCards.Location = new System.Drawing.Point(135, 224);
            this.CmbRaceCards.Name = "CmbRaceCards";
            this.CmbRaceCards.Size = new System.Drawing.Size(100, 24);
            this.CmbRaceCards.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Yarış Günü Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yarış Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bülten Seç:";
            // 
            // BtnCreateRaceDay
            // 
            this.BtnCreateRaceDay.Location = new System.Drawing.Point(135, 298);
            this.BtnCreateRaceDay.Name = "BtnCreateRaceDay";
            this.BtnCreateRaceDay.Size = new System.Drawing.Size(134, 30);
            this.BtnCreateRaceDay.TabIndex = 4;
            this.BtnCreateRaceDay.Text = "Yarış Günü Oluştur";
            this.BtnCreateRaceDay.UseVisualStyleBackColor = true;
            this.BtnCreateRaceDay.Click += new System.EventHandler(this.BtnCreateRaceDay_Click);
            // 
            // BtnAddRaceCard
            // 
            this.BtnAddRaceCard.Location = new System.Drawing.Point(265, 224);
            this.BtnAddRaceCard.Name = "BtnAddRaceCard";
            this.BtnAddRaceCard.Size = new System.Drawing.Size(110, 23);
            this.BtnAddRaceCard.TabIndex = 5;
            this.BtnAddRaceCard.Text = "Bülten Ekle";
            this.BtnAddRaceCard.UseVisualStyleBackColor = true;
            this.BtnAddRaceCard.Click += new System.EventHandler(this.BtnAddRaceCard_Click);
            // 
            // BtnDeleteRaceCard
            // 
            this.BtnDeleteRaceCard.Location = new System.Drawing.Point(623, 305);
            this.BtnDeleteRaceCard.Name = "BtnDeleteRaceCard";
            this.BtnDeleteRaceCard.Size = new System.Drawing.Size(110, 23);
            this.BtnDeleteRaceCard.TabIndex = 5;
            this.BtnDeleteRaceCard.Text = "Bülten Çıkar";
            this.BtnDeleteRaceCard.UseVisualStyleBackColor = true;
            this.BtnDeleteRaceCard.Click += new System.EventHandler(this.BtnDeleteRaceCard_Click);
            // 
            // LstRaceCards
            // 
            this.LstRaceCards.FormattingEnabled = true;
            this.LstRaceCards.ItemHeight = 16;
            this.LstRaceCards.Location = new System.Drawing.Point(491, 98);
            this.LstRaceCards.Name = "LstRaceCards";
            this.LstRaceCards.Size = new System.Drawing.Size(242, 180);
            this.LstRaceCards.TabIndex = 6;
            // 
            // CreateRaceDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LstRaceCards);
            this.Controls.Add(this.BtnDeleteRaceCard);
            this.Controls.Add(this.BtnAddRaceCard);
            this.Controls.Add(this.BtnCreateRaceDay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbRaceCards);
            this.Controls.Add(this.DTPRaceDay);
            this.Controls.Add(this.TxtRaceDayName);
            this.Name = "CreateRaceDay";
            this.Text = "CreateRaceDay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtRaceDayName;
        private System.Windows.Forms.DateTimePicker DTPRaceDay;
        private System.Windows.Forms.ComboBox CmbRaceCards;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCreateRaceDay;
        private System.Windows.Forms.Button BtnAddRaceCard;
        private System.Windows.Forms.Button BtnDeleteRaceCard;
        private System.Windows.Forms.ListBox LstRaceCards;
    }
}