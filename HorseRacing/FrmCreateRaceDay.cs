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
        public FrmCreateRaceDay(List<RaceCard> raceCards, List<RaceDay> raceDays)
        {
            InitializeComponent();

            _raceDays = raceDays;
        }





        private void BtnCreateRaceDay_Click(object sender, EventArgs e)
        {
            if(TxtRaceDayName.Text==null)
            {
                MessageBox.Show("Yarış İsmi Kısmı Boş Bırakılamaz.");
                return;
            }
            RaceDay raceDay = new RaceDay();
            {
                raceDay.Name = TxtRaceDayName.Text;
                raceDay.Date = DTPRaceDay.Value;


            }
            _raceDays.Add(raceDay);
            MessageBox.Show($"{raceDay.Name.ToString()} Adında Bir Yarış Günü Oluşturuldu.");
        }
    }
}
