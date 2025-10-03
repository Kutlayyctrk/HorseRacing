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
            this.BtnCreateRaceDay = new System.Windows.Forms.Button();
            this.dgvRaceDays = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaceDays)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCreateRaceDay
            // 
            this.BtnCreateRaceDay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnCreateRaceDay.Location = new System.Drawing.Point(309, 47);
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
            this.dgvRaceDays.Location = new System.Drawing.Point(12, 108);
            this.dgvRaceDays.Name = "dgvRaceDays";
            this.dgvRaceDays.RowHeadersWidth = 51;
            this.dgvRaceDays.RowTemplate.Height = 24;
            this.dgvRaceDays.Size = new System.Drawing.Size(742, 313);
            this.dgvRaceDays.TabIndex = 3;
            this.dgvRaceDays.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRaceDays_CellClick);
            // 
            // FrmCreateRaceDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 433);
            this.Controls.Add(this.dgvRaceDays);
            this.Controls.Add(this.BtnCreateRaceDay);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmCreateRaceDay";
            this.Text = "Race Days";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaceDays)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnCreateRaceDay;
        private System.Windows.Forms.DataGridView dgvRaceDays;
    }
}