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
            this.BtnAdd = new System.Windows.Forms.Button();
            this.dgvJockeys = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJockeys)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnAdd.Location = new System.Drawing.Point(258, 29);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(192, 34);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Add Jockey";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAddOrEdit_Click);
            // 
            // dgvJockeys
            // 
            this.dgvJockeys.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvJockeys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJockeys.Location = new System.Drawing.Point(12, 82);
            this.dgvJockeys.Name = "dgvJockeys";
            this.dgvJockeys.RowHeadersWidth = 51;
            this.dgvJockeys.RowTemplate.Height = 24;
            this.dgvJockeys.Size = new System.Drawing.Size(703, 277);
            this.dgvJockeys.TabIndex = 6;
            this.dgvJockeys.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJockeys_CellContentClick);
           
            // 
            // FrmCreateJockey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 371);
            this.Controls.Add(this.dgvJockeys);
            this.Controls.Add(this.BtnAdd);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmCreateJockey";
            this.Text = "Jockeys";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJockeys)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridView dgvJockeys;
    }
}