namespace HorseRacing
{
    partial class FrmRaceDayAddOrEdit
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
            this.BtnSaveOrEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtRaceDayName
            // 
            this.TxtRaceDayName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtRaceDayName.Location = new System.Drawing.Point(131, 44);
            this.TxtRaceDayName.Name = "TxtRaceDayName";
            this.TxtRaceDayName.Size = new System.Drawing.Size(208, 22);
            this.TxtRaceDayName.TabIndex = 0;
            // 
            // DTPRaceDay
            // 
            this.DTPRaceDay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DTPRaceDay.Location = new System.Drawing.Point(131, 99);
            this.DTPRaceDay.Name = "DTPRaceDay";
            this.DTPRaceDay.Size = new System.Drawing.Size(208, 22);
            this.DTPRaceDay.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date Of Race";
            // 
            // BtnSaveOrEdit
            // 
            this.BtnSaveOrEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnSaveOrEdit.Location = new System.Drawing.Point(163, 158);
            this.BtnSaveOrEdit.Name = "BtnSaveOrEdit";
            this.BtnSaveOrEdit.Size = new System.Drawing.Size(136, 23);
            this.BtnSaveOrEdit.TabIndex = 2;
            this.BtnSaveOrEdit.UseVisualStyleBackColor = true;
            this.BtnSaveOrEdit.Click += new System.EventHandler(this.BtnSaveOrEdit_Click);
            // 
            // FrmRaceDayAddOrEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 320);
            this.Controls.Add(this.BtnSaveOrEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTPRaceDay);
            this.Controls.Add(this.TxtRaceDayName);
            this.Name = "FrmRaceDayAddOrEdit";
            this.Text = "FrmRaceDayAddOrEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtRaceDayName;
        private System.Windows.Forms.DateTimePicker DTPRaceDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSaveOrEdit;
    }
}