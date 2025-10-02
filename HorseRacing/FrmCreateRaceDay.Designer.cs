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
            this.dgvRaceDays = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaceDays)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtRaceDayName
            // 
            this.TxtRaceDayName.Location = new System.Drawing.Point(118, 25);
            this.TxtRaceDayName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtRaceDayName.Name = "TxtRaceDayName";
            this.TxtRaceDayName.Size = new System.Drawing.Size(197, 22);
            this.TxtRaceDayName.TabIndex = 0;
            // 
            // DTPRaceDay
            // 
            this.DTPRaceDay.Location = new System.Drawing.Point(118, 58);
            this.DTPRaceDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTPRaceDay.Name = "DTPRaceDay";
            this.DTPRaceDay.Size = new System.Drawing.Size(197, 22);
            this.DTPRaceDay.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date Of Race";
            // 
            // BtnCreateRaceDay
            // 
            this.BtnCreateRaceDay.Location = new System.Drawing.Point(149, 99);
            this.BtnCreateRaceDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCreateRaceDay.Name = "BtnCreateRaceDay";
            this.BtnCreateRaceDay.Size = new System.Drawing.Size(133, 30);
            this.BtnCreateRaceDay.TabIndex = 2;
            this.BtnCreateRaceDay.Text = "Add Race Day";
            this.BtnCreateRaceDay.UseVisualStyleBackColor = true;
            this.BtnCreateRaceDay.Click += new System.EventHandler(this.BtnCreateRaceDay_Click);
            // 
            // dgvRaceDays
            // 
            this.dgvRaceDays.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRaceDays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaceDays.Location = new System.Drawing.Point(391, 12);
            this.dgvRaceDays.Name = "dgvRaceDays";
            this.dgvRaceDays.RowHeadersWidth = 51;
            this.dgvRaceDays.RowTemplate.Height = 24;
            this.dgvRaceDays.Size = new System.Drawing.Size(635, 426);
            this.dgvRaceDays.TabIndex = 3;
            // 
            // FrmCreateRaceDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 452);
            this.Controls.Add(this.dgvRaceDays);
            this.Controls.Add(this.BtnCreateRaceDay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTPRaceDay);
            this.Controls.Add(this.TxtRaceDayName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmCreateRaceDay";
            this.Text = "Race Days";
            this.Load += new System.EventHandler(this.FrmCreateRaceDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaceDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtRaceDayName;
        private System.Windows.Forms.DateTimePicker DTPRaceDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCreateRaceDay;
        private System.Windows.Forms.DataGridView dgvRaceDays;
    }
}