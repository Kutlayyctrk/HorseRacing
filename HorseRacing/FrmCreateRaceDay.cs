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
    public partial class FrmCreateRaceDay : FrmBase
    {
        private BindingList<RaceDay> _raceDays;
        private BindingList<RaceCard> _raceCards;
        public FrmCreateRaceDay(BindingList<RaceCard> raceCards, BindingList<RaceDay> raceDays)
        {
            InitializeComponent();

            _raceDays = raceDays;
            _raceCards = raceCards;
            dgvRaceDays.AutoGenerateColumns = false;
            GenerateDGVColumns();
            dgvRaceDays.DataSource = _raceDays;
            dgvRaceDays.CellClick += dgvRaceDays_CellClick;

        }

        public void GenerateDGVColumns()
        {

            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.DataPropertyName = "Id";
            idColumn.HeaderText = "Id";
            idColumn.Name = "Id";
            idColumn.ReadOnly = true;
            dgvRaceDays.Columns.Add(idColumn);


            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.DataPropertyName = "Name";
            nameColumn.HeaderText = "Name";
            nameColumn.Name = "Name";
            dgvRaceDays.Columns.Add(nameColumn);


            DataGridViewTextBoxColumn dateColumn = new DataGridViewTextBoxColumn();
            dateColumn.DataPropertyName = "Date";
            dateColumn.HeaderText = "Date";
            dateColumn.Name = "Date";
            dgvRaceDays.Columns.Add(dateColumn);


            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Text = "Edit";
            editButtonColumn.HeaderText = "Edit";
            editButtonColumn.Name = "Edit";
            editButtonColumn.UseColumnTextForButtonValue = true;
            dgvRaceDays.Columns.Add(editButtonColumn);


            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Name = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            dgvRaceDays.Columns.Add(deleteButtonColumn);
        }



        private void BtnCreateRaceDay_Click(object sender, EventArgs e)
        {
            FrmRaceDayAddOrEdit f1 = new FrmRaceDayAddOrEdit(_raceDays);
            f1.ShowDialog();
            dgvRaceDays.Refresh();
        }

        private void dgvRaceDays_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || !(dgvRaceDays.Columns[e.ColumnIndex] is DataGridViewButtonColumn))
                {
                    return;
                }

                RaceDay selectedRaceDay = dgvRaceDays.Rows[e.RowIndex].DataBoundItem as RaceDay;

                if (selectedRaceDay == null) return;

                string columnName = dgvRaceDays.Columns[e.ColumnIndex].Name;

                if (columnName == "Delete")
                {
                    bool isRaceDayAssignedToRaceCard = _raceCards.Any(r => r.raceDay == selectedRaceDay);
                    if (isRaceDayAssignedToRaceCard)
                    {
                        MessageBox.Show($"RaceDay {selectedRaceDay.Name} is ccurrently assigned to RaceCard and cannot be deleted", "Deletion Blocked");
                        return;
                    }
                    DialogResult reply = MessageBox.Show
                        ($"Are you sure you want to delete the RaceCard named '{selectedRaceDay.Name}'?", "Delete Confirm", MessageBoxButtons.YesNo);
                    if (reply == DialogResult.Yes)
                    {
                        _raceDays.Remove(selectedRaceDay);
                        MessageBox.Show($"'{selectedRaceDay.Name}' has been succesfully deleted.", "Succesfuly");
                    }

                }
                else if (columnName == "Edit")
                {
                    FrmRaceDayAddOrEdit f1 = new FrmRaceDayAddOrEdit(_raceDays, selectedRaceDay);
                    f1.ShowDialog();

                    BtnCreateRaceDay.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
