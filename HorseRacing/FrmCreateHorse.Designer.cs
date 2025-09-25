namespace HorseRacing
{
    partial class FrmCreateHorse
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
            this.TxtHorsaAge = new System.Windows.Forms.TextBox();
            this.TxtHorseRegion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCreateHorse = new System.Windows.Forms.Button();
            this.CmbJockey = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DgvHorses = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHorses)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtHorseName
            // 
            this.TxtHorseName.Location = new System.Drawing.Point(112, 18);
            this.TxtHorseName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtHorseName.Name = "TxtHorseName";
            this.TxtHorseName.Size = new System.Drawing.Size(100, 22);
            this.TxtHorseName.TabIndex = 0;
            // 
            // TxtHorsaAge
            // 
            this.TxtHorsaAge.Location = new System.Drawing.Point(112, 75);
            this.TxtHorsaAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtHorsaAge.Name = "TxtHorsaAge";
            this.TxtHorsaAge.Size = new System.Drawing.Size(100, 22);
            this.TxtHorsaAge.TabIndex = 1;
            // 
            // TxtHorseRegion
            // 
            this.TxtHorseRegion.Location = new System.Drawing.Point(112, 132);
            this.TxtHorseRegion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtHorseRegion.Name = "TxtHorseRegion";
            this.TxtHorseRegion.Size = new System.Drawing.Size(100, 22);
            this.TxtHorseRegion.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Region";
            // 
            // BtnCreateHorse
            // 
            this.BtnCreateHorse.Location = new System.Drawing.Point(123, 219);
            this.BtnCreateHorse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCreateHorse.Name = "BtnCreateHorse";
            this.BtnCreateHorse.Size = new System.Drawing.Size(89, 34);
            this.BtnCreateHorse.TabIndex = 4;
            this.BtnCreateHorse.Text = "Add Horse";
            this.BtnCreateHorse.UseVisualStyleBackColor = true;
            this.BtnCreateHorse.Click += new System.EventHandler(this.BtnCreateHorse_Click);
            // 
            // CmbJockey
            // 
            this.CmbJockey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbJockey.FormattingEnabled = true;
            this.CmbJockey.Location = new System.Drawing.Point(112, 175);
            this.CmbJockey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbJockey.Name = "CmbJockey";
            this.CmbJockey.Size = new System.Drawing.Size(100, 24);
            this.CmbJockey.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Choose Jockey";
            // 
            // DgvHorses
            // 
            this.DgvHorses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvHorses.Location = new System.Drawing.Point(218, 18);
            this.DgvHorses.Name = "DgvHorses";
            this.DgvHorses.RowHeadersWidth = 51;
            this.DgvHorses.RowTemplate.Height = 24;
            this.DgvHorses.Size = new System.Drawing.Size(751, 420);
            this.DgvHorses.TabIndex = 5;
            // 
            // FrmCreateHorse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 450);
            this.Controls.Add(this.DgvHorses);
            this.Controls.Add(this.CmbJockey);
            this.Controls.Add(this.BtnCreateHorse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtHorseRegion);
            this.Controls.Add(this.TxtHorsaAge);
            this.Controls.Add(this.TxtHorseName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmCreateHorse";
            this.Text = "Horses";
            ((System.ComponentModel.ISupportInitialize)(this.DgvHorses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtHorseName;
        private System.Windows.Forms.TextBox TxtHorsaAge;
        private System.Windows.Forms.TextBox TxtHorseRegion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCreateHorse;
        private System.Windows.Forms.ComboBox CmbJockey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DgvHorses;
    }
}