using HorseRacing.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseRacing
{

    public partial class FrmCreateJockey : FrmBase
    {

        private BindingList<Jockey> _jockeys;

        public FrmCreateJockey(BindingList<Jockey> jockeys)
        {
            InitializeComponent();
            _jockeys = jockeys;
            dgvJockeys.AutoGenerateColumns = false;
            GenerateDGVColumns();
            dgvJockeys.DataSource = _jockeys;
            dgvJockeys.CellContentClick += dgvJockeys_CellContentClick;


        }
        // Aksiyon butonları(Delete Ve edit) dgv'nin otomatik satır yaratma özelliğini kapatıp manuel olarak ekledim. Sadece aksiyon butonlarını olusturup Id,Name,Age sütunlarını autogenerate'e bırakırsam manuel eklenecek aksiyon butonlarıyla otomatik eklenecek satırlar index içeren timing hatası veriyor buda aksiyon butonlarına tıklandıgında indexoutofrange hatası veriyorr 
        public void GenerateDGVColumns()
        {

            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.DataPropertyName = "Id";
            idColumn.HeaderText = "Id";
            idColumn.Name = "Id";
            idColumn.ReadOnly = true;
            dgvJockeys.Columns.Add(idColumn);


            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.DataPropertyName = "Name";
            nameColumn.HeaderText = "Name";
            nameColumn.Name = "Name";
            dgvJockeys.Columns.Add(nameColumn);


            DataGridViewTextBoxColumn ageColumn = new DataGridViewTextBoxColumn();
            ageColumn.DataPropertyName = "Age";
            ageColumn.HeaderText = "Age";
            ageColumn.Name = "Age";
            dgvJockeys.Columns.Add(ageColumn);


            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Text = "Edit";
            editButtonColumn.HeaderText = "Edit";
            editButtonColumn.Name = "Edit";
            editButtonColumn.UseColumnTextForButtonValue = true;
            dgvJockeys.Columns.Add(editButtonColumn);


            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Name = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            dgvJockeys.Columns.Add(deleteButtonColumn);
        }


        private void BtnAddOrEdit_Click(object sender, EventArgs e)
        {
            FrmJockeyAddOrEdit f1 = new FrmJockeyAddOrEdit(_jockeys);
            f1.ShowDialog();
            dgvJockeys.Refresh();
        }


        private void dgvJockeys_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                if (e.RowIndex < 0 || !(dgvJockeys.Columns[e.ColumnIndex] is DataGridViewButtonColumn))
                {
                    return;
                }

                Jockey selectedJockey = dgvJockeys.Rows[e.RowIndex].DataBoundItem as Jockey;

                if (selectedJockey == null) return;

                string columnName = dgvJockeys.Columns[e.ColumnIndex].Name;

                if (columnName == "Delete")
                {

                    DialogResult reply = MessageBox.Show(
                        $"'Are you sure you want to delete the jockey named '{selectedJockey.Name}'?", "Delete Confirm", MessageBoxButtons.YesNo);

                    if (reply == DialogResult.Yes)
                    {
                        _jockeys.Remove(selectedJockey);
                        MessageBox.Show($"{selectedJockey.Name}' has been successfully deleted.", "Successful");
                    }
                }
                else if (columnName == "Edit")
                {
                    FrmJockeyAddOrEdit editForm = new FrmJockeyAddOrEdit(_jockeys, selectedJockey);
                    editForm.ShowDialog();
                    dgvJockeys.Refresh();
                    BtnAdd.Focus();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }


    }
}

