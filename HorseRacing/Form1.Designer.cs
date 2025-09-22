namespace HorseRacing
{
    partial class Form1
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
            this.TxtJokeyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtJokeyAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnJockey = new System.Windows.Forms.Button();
            this.BtnHorse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtJokeyName
            // 
            this.TxtJokeyName.Location = new System.Drawing.Point(141, 109);
            this.TxtJokeyName.Name = "TxtJokeyName";
            this.TxtJokeyName.Size = new System.Drawing.Size(100, 22);
            this.TxtJokeyName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jokey Adı Gir:";
            // 
            // TxtJokeyAge
            // 
            this.TxtJokeyAge.Location = new System.Drawing.Point(141, 137);
            this.TxtJokeyAge.Name = "TxtJokeyAge";
            this.TxtJokeyAge.Size = new System.Drawing.Size(100, 22);
            this.TxtJokeyAge.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jokey Yaşı Gir:";
            // 
            // BtnJockey
            // 
            this.BtnJockey.Location = new System.Drawing.Point(141, 191);
            this.BtnJockey.Name = "BtnJockey";
            this.BtnJockey.Size = new System.Drawing.Size(100, 29);
            this.BtnJockey.TabIndex = 2;
            this.BtnJockey.Text = "Jokey Oluştur";
            this.BtnJockey.UseVisualStyleBackColor = true;
            this.BtnJockey.Click += new System.EventHandler(this.BtnJockey_Click);
            // 
            // BtnHorse
            // 
            this.BtnHorse.Location = new System.Drawing.Point(306, 169);
            this.BtnHorse.Name = "BtnHorse";
            this.BtnHorse.Size = new System.Drawing.Size(138, 51);
            this.BtnHorse.TabIndex = 3;
            this.BtnHorse.Text = "At Oluşturma Ekranı";
            this.BtnHorse.UseVisualStyleBackColor = true;
            this.BtnHorse.Click += new System.EventHandler(this.BtnHorse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 309);
            this.Controls.Add(this.BtnHorse);
            this.Controls.Add(this.BtnJockey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtJokeyAge);
            this.Controls.Add(this.TxtJokeyName);
            this.Name = "Form1";
            this.Text = "Jokey Oluştur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtJokeyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtJokeyAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnJockey;
        private System.Windows.Forms.Button BtnHorse;
    }
}

