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

            _raceDays = new BindingList<RaceDay>(raceDays);
            _raceCards = new BindingList<RaceCard>(raceCards);
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
                
                dgvRaceDays.DataSource=_raceDays;
                MessageBox.Show($"Race Day has been created named by:"+Environment.NewLine+raceDay.Name);
                TxtRaceDayName.Text = string.Empty;
            }
            catch (Exception ex)
            {

                 MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
