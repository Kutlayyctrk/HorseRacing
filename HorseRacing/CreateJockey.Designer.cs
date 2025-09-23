namespace HorseRacing
{
    partial class CreateJockey
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
            this.TxtJockeyName = new System.Windows.Forms.TextBox();
            this.TxtJockeyAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCreateJockey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtJockeyName
            // 
            this.TxtJockeyName.Location = new System.Drawing.Point(150, 118);
            this.TxtJockeyName.Name = "TxtJockeyName";
            this.TxtJockeyName.Size = new System.Drawing.Size(100, 22);
            this.TxtJockeyName.TabIndex = 0;
            // 
            // TxtJockeyAge
            // 
            this.TxtJockeyAge.Location = new System.Drawing.Point(150, 171);
            this.TxtJockeyAge.Name = "TxtJockeyAge";
            this.TxtJockeyAge.Size = new System.Drawing.Size(100, 22);
            this.TxtJockeyAge.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jokey Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jokey Yaşı:";
            // 
            // BtnCreateJockey
            // 
            this.BtnCreateJockey.Location = new System.Drawing.Point(150, 235);
            this.BtnCreateJockey.Name = "BtnCreateJockey";
            this.BtnCreateJockey.Size = new System.Drawing.Size(100, 23);
            this.BtnCreateJockey.TabIndex = 2;
            this.BtnCreateJockey.Text = "Jokey Oluştur";
            this.BtnCreateJockey.UseVisualStyleBackColor = true;
            this.BtnCreateJockey.Click += new System.EventHandler(this.BtnCreateJockey_Click);
            // 
            // CreateJockey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 450);
            this.Controls.Add(this.BtnCreateJockey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtJockeyAge);
            this.Controls.Add(this.TxtJockeyName);
            this.Name = "CreateJockey";
            this.Text = "CreateJockey";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtJockeyName;
        private System.Windows.Forms.TextBox TxtJockeyAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCreateJockey;
    }
}