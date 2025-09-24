namespace HorseRacing
{
    partial class FrmCreateJockey
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
            this.lblJokeyName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCreateJockey = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtJockeyName
            // 
            this.TxtJockeyName.Location = new System.Drawing.Point(59, 4);
            this.TxtJockeyName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtJockeyName.Name = "TxtJockeyName";
            this.TxtJockeyName.Size = new System.Drawing.Size(111, 20);
            this.TxtJockeyName.TabIndex = 0;
            // 
            // TxtJockeyAge
            // 
            this.TxtJockeyAge.Location = new System.Drawing.Point(59, 28);
            this.TxtJockeyAge.Margin = new System.Windows.Forms.Padding(2);
            this.TxtJockeyAge.Name = "TxtJockeyAge";
            this.TxtJockeyAge.Size = new System.Drawing.Size(111, 20);
            this.TxtJockeyAge.TabIndex = 1;
            // 
            // lblJokeyName
            // 
            this.lblJokeyName.AutoSize = true;
            this.lblJokeyName.Location = new System.Drawing.Point(11, 9);
            this.lblJokeyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJokeyName.Name = "lblJokeyName";
            this.lblJokeyName.Size = new System.Drawing.Size(35, 13);
            this.lblJokeyName.TabIndex = 1;
            this.lblJokeyName.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age";
            // 
            // BtnCreateJockey
            // 
            this.BtnCreateJockey.Location = new System.Drawing.Point(84, 52);
            this.BtnCreateJockey.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCreateJockey.Name = "BtnCreateJockey";
            this.BtnCreateJockey.Size = new System.Drawing.Size(86, 28);
            this.BtnCreateJockey.TabIndex = 2;
            this.BtnCreateJockey.Text = "Add Jokey";
            this.BtnCreateJockey.UseVisualStyleBackColor = true;
            this.BtnCreateJockey.Click += new System.EventHandler(this.BtnCreateJockey_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(175, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(378, 360);
            this.dataGridView1.TabIndex = 3;
            // 
            // FrmCreateJockey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 373);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnCreateJockey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblJokeyName);
            this.Controls.Add(this.TxtJockeyAge);
            this.Controls.Add(this.TxtJockeyName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCreateJockey";
            this.Text = "Jockeys";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtJockeyName;
        private System.Windows.Forms.TextBox TxtJockeyAge;
        private System.Windows.Forms.Label lblJokeyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCreateJockey;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}