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
    public partial class FrmCreateHorse : FrmBase
    {
        private BindingList<Horse> _horses;
        private BindingList<Jockey> _jockeys;
        private BindingList<Race> _races;
        public FrmCreateHorse(BindingList<Horse> horses, BindingList<Jockey> jockeys, BindingList<Race> races)
        {
            InitializeComponent();
            _horses = new BindingList<Horse>(horses);
            _horses = horses;
            _jockeys = jockeys;
            _races = races;
            DgvHorses.AutoGenerateColumns = false;
            GenerateDGVColumns();
            DgvHorses.DataSource = _horses;
            DgvHorses.CellContentClick += DgvHorses_CellContentClick;




        }
        public void GenerateDGVColumns()
        {

            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.DataPropertyName = "Id";
            idColumn.HeaderText = "Id";
            idColumn.Name = "Id";
            idColumn.ReadOnly = true;
            DgvHorses.Columns.Add(idColumn);


            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.DataPropertyName = "Name";
            nameColumn.HeaderText = "Name";
            nameColumn.Name = "Name";
            DgvHorses.Columns.Add(nameColumn);


            DataGridViewTextBoxColumn ageColumn = new DataGridViewTextBoxColumn();
            ageColumn.DataPropertyName = "Age";
            ageColumn.HeaderText = "Age";
            ageColumn.Name = "Age";
            DgvHorses.Columns.Add(ageColumn);

            DataGridViewTextBoxColumn regionColumn = new DataGridViewTextBoxColumn();
            regionColumn.DataPropertyName = "Region";
            regionColumn.HeaderText = "Region";
            regionColumn.Name = "Region";
            DgvHorses.Columns.Add(regionColumn);

            DataGridViewTextBoxColumn jockeyColumn = new DataGridViewTextBoxColumn();
            jockeyColumn.DataPropertyName = "Jockey";
            jockeyColumn.HeaderText = "Jockey";
            jockeyColumn.Name = "Jockey";
            DgvHorses.Columns.Add(jockeyColumn);

            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Text = "Edit";
            editButtonColumn.HeaderText = "Edit";
            editButtonColumn.Name = "Edit";
            editButtonColumn.UseColumnTextForButtonValue = true;
            DgvHorses.Columns.Add(editButtonColumn);


            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Name = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            DgvHorses.Columns.Add(deleteButtonColumn);
        }


        private void BtnCreateHorse_Click(object sender, EventArgs e)
        {
            FrmHorseAddOrEdit f1 = new FrmHorseAddOrEdit(_jockeys, _horses);
            f1.ShowDialog();
            DgvHorses.Refresh();
        }

        private void FrmCreateHorse_Load(object sender, EventArgs e)
        {


        }

        private void DgvHorses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || !(DgvHorses.Columns[e.ColumnIndex] is DataGridViewButtonColumn))
                {
                    return;
                }
                Horse selectedHorse = DgvHorses.Rows[e.RowIndex].DataBoundItem as Horse;

                if (selectedHorse == null) return;

                string columnName = DgvHorses.Columns[e.ColumnIndex].Name;
                if (columnName == "Delete")
                {
                    bool isHorseAssignedToRace = _races.Any(r => r.Horses.Contains(selectedHorse)); //Silinecek atın herhangi bir yarışta olup olmadıgını kontrol ediyoruz.
                    if (isHorseAssignedToRace)
                    {
                        MessageBox.Show($"Horse {selectedHorse.Name} is currently assigned to race and cannot be deleted.", "Deletion Blocked");
                        return;
                    }
                    DialogResult reply = MessageBox.Show
                        ($"Are you sure you want to delete the horse named '{selectedHorse.Name}'?", "Delete Confirm", MessageBoxButtons.YesNo);
                    if (reply == DialogResult.Yes)
                    {
                        _horses.Remove(selectedHorse);
                        MessageBox.Show($"'{selectedHorse.Name}' has been succesfully deleted", "Succesfully");
                    }
                }
                else if (columnName == "Edit")
                {
                    FrmHorseAddOrEdit editForm = new FrmHorseAddOrEdit(_jockeys, _races, _horses, selectedHorse);
                    editForm.ShowDialog();
                    DgvHorses.Refresh();
                    BtnCreateHorse.Focus();
                }



            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
