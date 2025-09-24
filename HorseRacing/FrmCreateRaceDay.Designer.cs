namespace HorseRacing
{
    partial class FrmCreateRaceDay
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCreateRaceDay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtRaceDayName
            // 
            this.TxtRaceDayName.Location = new System.Drawing.Point(101, 92);
            this.TxtRaceDayName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtRaceDayName.Name = "TxtRaceDayName";
            this.TxtRaceDayName.Size = new System.Drawing.Size(76, 20);
            this.TxtRaceDayName.TabIndex = 0;
            // 
            // DTPRaceDay
            // 
            this.DTPRaceDay.Location = new System.Drawing.Point(101, 134);
            this.DTPRaceDay.Margin = new System.Windows.Forms.Padding(2);
            this.DTPRaceDay.Name = "DTPRaceDay";
            this.DTPRaceDay.Size = new System.Drawing.Size(149, 20);
            this.DTPRaceDay.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Yarış Günü Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yarış Tarihi:";
            // 
            // BtnCreateRaceDay
            // 
            this.BtnCreateRaceDay.Location = new System.Drawing.Point(148, 189);
            this.BtnCreateRaceDay.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCreateRaceDay.Name = "BtnCreateRaceDay";
            this.BtnCreateRaceDay.Size = new System.Drawing.Size(100, 24);
            this.BtnCreateRaceDay.TabIndex = 4;
            this.BtnCreateRaceDay.Text = "Yarış Günü Oluştur";
            this.BtnCreateRaceDay.UseVisualStyleBackColor = true;
            this.BtnCreateRaceDay.Click += new System.EventHandler(this.BtnCreateRaceDay_Click);
            // 
            // FrmCreateRaceDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.BtnCreateRaceDay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTPRaceDay);
            this.Controls.Add(this.TxtRaceDayName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCreateRaceDay";
            this.Text = "CreateRaceDay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtRaceDayName;
        private System.Windows.Forms.DateTimePicker DTPRaceDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCreateRaceDay;
    }
}