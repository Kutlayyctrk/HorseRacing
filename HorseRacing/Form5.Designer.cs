namespace HorseRacing
{
    partial class Form5
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
            this.CmbRaceCard = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DTPRaceDay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.LstRaceDay = new System.Windows.Forms.ListBox();
            this.BtnRaceList = new System.Windows.Forms.Button();
            this.TxtRaceDayName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmbRaceCard
            // 
            this.CmbRaceCard.FormattingEnabled = true;
            this.CmbRaceCard.Location = new System.Drawing.Point(134, 177);
            this.CmbRaceCard.Name = "CmbRaceCard";
            this.CmbRaceCard.Size = new System.Drawing.Size(121, 24);
            this.CmbRaceCard.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bülten Seçin:";
            // 
            // DTPRaceDay
            // 
            this.DTPRaceDay.Location = new System.Drawing.Point(134, 94);
            this.DTPRaceDay.Name = "DTPRaceDay";
            this.DTPRaceDay.Size = new System.Drawing.Size(200, 22);
            this.DTPRaceDay.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tarih Seçin:";
            // 
            // LstRaceDay
            // 
            this.LstRaceDay.FormattingEnabled = true;
            this.LstRaceDay.ItemHeight = 16;
            this.LstRaceDay.Location = new System.Drawing.Point(486, 85);
            this.LstRaceDay.Name = "LstRaceDay";
            this.LstRaceDay.Size = new System.Drawing.Size(302, 260);
            this.LstRaceDay.TabIndex = 4;
            // 
            // BtnRaceList
            // 
            this.BtnRaceList.Location = new System.Drawing.Point(134, 214);
            this.BtnRaceList.Name = "BtnRaceList";
            this.BtnRaceList.Size = new System.Drawing.Size(130, 48);
            this.BtnRaceList.TabIndex = 5;
            this.BtnRaceList.Text = "Yarış Listesine Ekle";
            this.BtnRaceList.UseVisualStyleBackColor = true;
            this.BtnRaceList.Click += new System.EventHandler(this.BtnRaceList_Click);
            // 
            // TxtRaceDayName
            // 
            this.TxtRaceDayName.Location = new System.Drawing.Point(134, 138);
            this.TxtRaceDayName.Name = "TxtRaceDayName";
            this.TxtRaceDayName.Size = new System.Drawing.Size(121, 22);
            this.TxtRaceDayName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "İsim belirleyin:";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtRaceDayName);
            this.Controls.Add(this.BtnRaceList);
            this.Controls.Add(this.LstRaceDay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DTPRaceDay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbRaceCard);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbRaceCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DTPRaceDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LstRaceDay;
        private System.Windows.Forms.Button BtnRaceList;
        private System.Windows.Forms.TextBox TxtRaceDayName;
        private System.Windows.Forms.Label label3;
    }
}