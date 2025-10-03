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
            this.BtnCreateHorse = new System.Windows.Forms.Button();
            this.DgvHorses = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHorses)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCreateHorse
            // 
            this.BtnCreateHorse.Location = new System.Drawing.Point(279, 21);
            this.BtnCreateHorse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCreateHorse.Name = "BtnCreateHorse";
            this.BtnCreateHorse.Size = new System.Drawing.Size(178, 34);
            this.BtnCreateHorse.TabIndex = 4;
            this.BtnCreateHorse.Text = "Add Horse";
            this.BtnCreateHorse.UseVisualStyleBackColor = true;
            this.BtnCreateHorse.Click += new System.EventHandler(this.BtnCreateHorse_Click);
            // 
            // DgvHorses
            // 
            this.DgvHorses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvHorses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvHorses.Location = new System.Drawing.Point(12, 70);
            this.DgvHorses.Name = "DgvHorses";
            this.DgvHorses.RowHeadersWidth = 51;
            this.DgvHorses.RowTemplate.Height = 24;
            this.DgvHorses.Size = new System.Drawing.Size(730, 420);
            this.DgvHorses.TabIndex = 5;
            this.DgvHorses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvHorses_CellContentClick);
            // 
            // FrmCreateHorse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 502);
            this.Controls.Add(this.DgvHorses);
            this.Controls.Add(this.BtnCreateHorse);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmCreateHorse";
            this.Text = "Horses";
            this.Load += new System.EventHandler(this.FrmCreateHorse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvHorses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnCreateHorse;
        private System.Windows.Forms.DataGridView DgvHorses;
    }
}