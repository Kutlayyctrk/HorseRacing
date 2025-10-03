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
    public partial class FrmRaceDayAddOrEdit : FrmBase
    {
        private BindingList<RaceDay> _raceDays;
        private RaceDay _currentRaceDay;
        public FrmRaceDayAddOrEdit(BindingList<RaceDay> raceDays)//İlk ekleme yapılırken acılacak form consturctor'ı
        {
            InitializeComponent();
            _raceDays = raceDays;
            _currentRaceDay = new RaceDay();
            Text = "Add New RaceDay";
            BtnSaveOrEdit.Text = "Save";


        }
        public FrmRaceDayAddOrEdit(BindingList<RaceDay> raceDays, RaceDay editRaceDay)
        {
            InitializeComponent();
            _raceDays = raceDays;
            _currentRaceDay = editRaceDay;
            Text = $"Edit to{editRaceDay.Name}";
            BtnSaveOrEdit.Text = "Edit";
            LoadData();
            
        }

        public void LoadData()
        {
            TxtRaceDayName.Text = _currentRaceDay.Name;
            DTPRaceDay.Value = _currentRaceDay.Date;
        }

        private void BtnSaveOrEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtRaceDayName.Text))
                {
                    MessageBox.Show("Raceday name cannot be empty");
                    return;
                }

                _currentRaceDay.Name = TxtRaceDayName.Text;
                _currentRaceDay.Date = DTPRaceDay.Value;

                if(_currentRaceDay.Id==0)
                {
                    RaceDay raceDay = new RaceDay(_currentRaceDay.Name,_currentRaceDay.Date);
                    _raceDays.Add(raceDay);
                    MessageBox.Show($"Raceday has been succesfuly created: {raceDay.Name}");
                    TxtRaceDayName.Text = string.Empty;
                    DTPRaceDay.Value=DateTime.Now;
                    TxtRaceDayName.Focus();

                }
                else
                {
                    MessageBox.Show($"Raceday has been succesfully updated: {_currentRaceDay.Name}");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return;
            }

        }
    }
}
