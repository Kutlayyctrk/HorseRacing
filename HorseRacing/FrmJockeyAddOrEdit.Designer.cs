namespace HorseRacing
{
    partial class FrmJockeyAddOrEdit
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
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtJockeyName = new System.Windows.Forms.TextBox();
            this.TxtJockeyAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnSave.Location = new System.Drawing.Point(81, 117);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(106, 23);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtJockeyName
            // 
            this.TxtJockeyName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtJockeyName.Location = new System.Drawing.Point(81, 34);
            this.TxtJockeyName.Name = "TxtJockeyName";
            this.TxtJockeyName.Size = new System.Drawing.Size(148, 22);
            this.TxtJockeyName.TabIndex = 0;
            // 
            // TxtJockeyAge
            // 
            this.TxtJockeyAge.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtJockeyAge.Location = new System.Drawing.Point(81, 80);
            this.TxtJockeyAge.Name = "TxtJockeyAge";
            this.TxtJockeyAge.Size = new System.Drawing.Size(148, 22);
            this.TxtJockeyAge.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Age";
            // 
            // FrmJockeyAddOrEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtJockeyAge);
            this.Controls.Add(this.TxtJockeyName);
            this.Controls.Add(this.BtnSave);
            this.Name = "FrmJockeyAddOrEdit";
            this.Text = "JockeyAddOrEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TxtJockeyName;
        private System.Windows.Forms.TextBox TxtJockeyAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}