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
        private List<RaceDay> _raceDays;
        private List<RaceCard> _raceCards;
        public FrmCreateRaceDay(List<RaceCard> raceCards, List<RaceDay> raceDays)
        {
            InitializeComponent();

            _raceDays = raceDays;
            _raceCards = raceCards;
            dgvRaceDays.DataSource = _raceDays;
            
            
        }





        private void BtnCreateRaceDay_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(TxtRaceDayName.Text))
                {
                    MessageBox.Show("RaceDay name cannot be Empty!");
                    return;
                }
                RaceDay raceDay = new RaceDay();
                {
                    raceDay.Name = TxtRaceDayName.Text;
                    raceDay.Date = DTPRaceDay.Value;


                }
                _raceDays.Add(raceDay);
                dgvRaceDays.DataSource = null;
                dgvRaceDays.DataSource=_raceDays;
                MessageBox.Show($"Race Day has been created named by:"+Environment.NewLine+raceDay.Name);
                TxtRaceDayName.Text = null;
            }
            catch (Exception ex)
            {

                 MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
