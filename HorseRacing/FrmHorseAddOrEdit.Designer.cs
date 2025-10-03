namespace HorseRacing
{
    partial class FrmHorseAddOrEdit
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
            this.TxtHorseName = new System.Windows.Forms.TextBox();
            this.TxtHorseAge = new System.Windows.Forms.TextBox();
            this.TxtHorseRegion = new System.Windows.Forms.TextBox();
            this.CmbJockey = new System.Windows.Forms.ComboBox();
            this.BtnAddOrEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtHorseName
            // 
            this.TxtHorseName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtHorseName.Location = new System.Drawing.Point(144, 42);
            this.TxtHorseName.Name = "TxtHorseName";
            this.TxtHorseName.Size = new System.Drawing.Size(152, 22);
            this.TxtHorseName.TabIndex = 0;
            // 
            // TxtHorseAge
            // 
            this.TxtHorseAge.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtHorseAge.Location = new System.Drawing.Point(144, 84);
            this.TxtHorseAge.Name = "TxtHorseAge";
            this.TxtHorseAge.Size = new System.Drawing.Size(152, 22);
            this.TxtHorseAge.TabIndex = 1;
            // 
            // TxtHorseRegion
            // 
            this.TxtHorseRegion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtHorseRegion.Location = new System.Drawing.Point(144, 129);
            this.TxtHorseRegion.Name = "TxtHorseRegion";
            this.TxtHorseRegion.Size = new System.Drawing.Size(152, 22);
            this.TxtHorseRegion.TabIndex = 2;
            // 
            // CmbJockey
            // 
            this.CmbJockey.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CmbJockey.FormattingEnabled = true;
            this.CmbJockey.Location = new System.Drawing.Point(144, 181);
            this.CmbJockey.Name = "CmbJockey";
            this.CmbJockey.Size = new System.Drawing.Size(152, 24);
            this.CmbJockey.TabIndex = 3;
            // 
            // BtnAddOrEdit
            // 
            this.BtnAddOrEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnAddOrEdit.Location = new System.Drawing.Point(144, 226);
            this.BtnAddOrEdit.Name = "BtnAddOrEdit";
            this.BtnAddOrEdit.Size = new System.Drawing.Size(152, 23);
            this.BtnAddOrEdit.TabIndex = 4;
            this.BtnAddOrEdit.UseVisualStyleBackColor = true;
            this.BtnAddOrEdit.Click += new System.EventHandler(this.BtnAddOrEdit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Region";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Choose Jockey";
            // 
            // FrmHorseAddOrEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 342);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAddOrEdit);
            this.Controls.Add(this.CmbJockey);
            this.Controls.Add(this.TxtHorseRegion);
            this.Controls.Add(this.TxtHorseAge);
            this.Controls.Add(this.TxtHorseName);
            this.Name = "FrmHorseAddOrEdit";
            this.Text = "FrmHorseAddOrEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtHorseName;
        private System.Windows.Forms.TextBox TxtHorseAge;
        private System.Windows.Forms.TextBox TxtHorseRegion;
        private System.Windows.Forms.ComboBox CmbJockey;
        private System.Windows.Forms.Button BtnAddOrEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}