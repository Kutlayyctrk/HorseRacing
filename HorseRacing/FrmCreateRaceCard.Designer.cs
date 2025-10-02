namespace HorseRacing
{
    partial class FrmCreateRaceCard
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
            this.dgvRaceCards = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaceCards)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtRaceCardName
            // 
            this.TxtRaceCardName.Location = new System.Drawing.Point(118, 9);
            this.TxtRaceCardName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtRaceCardName.Name = "TxtRaceCardName";
            this.TxtRaceCardName.Size = new System.Drawing.Size(165, 22);
            this.TxtRaceCardName.TabIndex = 0;
            // 
            // TxtRaceCardPlace
            // 
            this.TxtRaceCardPlace.Location = new System.Drawing.Point(118, 49);
            this.TxtRaceCardPlace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtRaceCardPlace.Name = "TxtRaceCardPlace";
            this.TxtRaceCardPlace.Size = new System.Drawing.Size(165, 22);
            this.TxtRaceCardPlace.TabIndex = 1;
            // 
            // CmbRaceDays
            // 
            this.CmbRaceDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbRaceDays.FormattingEnabled = true;
            this.CmbRaceDays.Location = new System.Drawing.Point(118, 90);
            this.CmbRaceDays.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbRaceDays.Name = "CmbRaceDays";
            this.CmbRaceDays.Size = new System.Drawing.Size(165, 24);
            this.CmbRaceDays.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Race Day";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "City";
            // 
            // BtnCreateRaceCard
            // 
            this.BtnCreateRaceCard.Location = new System.Drawing.Point(118, 130);
            this.BtnCreateRaceCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCreateRaceCard.Name = "BtnCreateRaceCard";
            this.BtnCreateRaceCard.Size = new System.Drawing.Size(165, 41);
            this.BtnCreateRaceCard.TabIndex = 3;
            this.BtnCreateRaceCard.Text = "Add Bulletin";
            this.BtnCreateRaceCard.UseVisualStyleBackColor = true;
            this.BtnCreateRaceCard.Click += new System.EventHandler(this.BtnCreateRaceCard_Click);
            // 
            // dgvRaceCards
            // 
            this.dgvRaceCards.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRaceCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaceCards.Location = new System.Drawing.Point(300, 12);
            this.dgvRaceCards.Name = "dgvRaceCards";
            this.dgvRaceCards.RowHeadersWidth = 51;
            this.dgvRaceCards.RowTemplate.Height = 24;
            this.dgvRaceCards.Size = new System.Drawing.Size(488, 426);
            this.dgvRaceCards.TabIndex = 4;
            // 
            // FrmCreateRaceCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvRaceCards);
            this.Controls.Add(this.BtnCreateRaceCard);
            this.Controls.Add(this.CmbRaceDays);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtRaceCardPlace);
            this.Controls.Add(this.TxtRaceCardName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmCreateRaceCard";
            this.Text = "RaceCards";
            this.Load += new System.EventHandler(this.FrmCreateRaceCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaceCards)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvRaceCards;
    }
}