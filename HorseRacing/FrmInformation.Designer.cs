namespace HorseRacing
{
    partial class FrmInformation
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
            this.DgvRaceDay = new System.Windows.Forms.DataGridView();
            this.dgvRaceCard = new System.Windows.Forms.DataGridView();
            this.dgvHorse = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvRace = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRaceDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaceCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRace)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvRaceDay
            // 
            this.DgvRaceDay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DgvRaceDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRaceDay.Location = new System.Drawing.Point(12, 34);
            this.DgvRaceDay.Name = "DgvRaceDay";
            this.DgvRaceDay.RowHeadersWidth = 51;
            this.DgvRaceDay.RowTemplate.Height = 24;
            this.DgvRaceDay.Size = new System.Drawing.Size(441, 857);
            this.DgvRaceDay.TabIndex = 0;
            this.DgvRaceDay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvRaceDay_CellClick);
            // 
            // dgvRaceCard
            // 
            this.dgvRaceCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvRaceCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaceCard.Location = new System.Drawing.Point(472, 34);
            this.dgvRaceCard.Name = "dgvRaceCard";
            this.dgvRaceCard.RowHeadersWidth = 51;
            this.dgvRaceCard.RowTemplate.Height = 24;
            this.dgvRaceCard.Size = new System.Drawing.Size(439, 857);
            this.dgvRaceCard.TabIndex = 1;
            this.dgvRaceCard.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRaceCard_CellClick);
            // 
            // dgvHorse
            // 
            this.dgvHorse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvHorse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorse.Location = new System.Drawing.Point(1383, 34);
            this.dgvHorse.Name = "dgvHorse";
            this.dgvHorse.RowHeadersWidth = 51;
            this.dgvHorse.RowTemplate.Height = 24;
            this.dgvHorse.Size = new System.Drawing.Size(432, 857);
            this.dgvHorse.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Race Day";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(469, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(442, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Race Card";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(1380, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(435, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Horse";
            // 
            // dgvRace
            // 
            this.dgvRace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvRace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRace.Location = new System.Drawing.Point(927, 34);
            this.dgvRace.Name = "dgvRace";
            this.dgvRace.RowHeadersWidth = 51;
            this.dgvRace.RowTemplate.Height = 24;
            this.dgvRace.Size = new System.Drawing.Size(438, 857);
            this.dgvRace.TabIndex = 2;
            this.dgvRace.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRace_CellClick);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(924, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(441, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Race";
            // 
            // FrmInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1833, 912);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRace);
            this.Controls.Add(this.dgvHorse);
            this.Controls.Add(this.dgvRaceCard);
            this.Controls.Add(this.DgvRaceDay);
            this.Name = "FrmInformation";
            this.Text = "Information";
            ((System.ComponentModel.ISupportInitialize)(this.DgvRaceDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaceCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvRaceDay;
        private System.Windows.Forms.DataGridView dgvRaceCard;
        private System.Windows.Forms.DataGridView dgvHorse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvRace;
        private System.Windows.Forms.Label label4;
    }
}