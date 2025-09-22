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
    public partial class Form5 : Form
    {
        public Form5(List<RaceCard> raceCards)
        {
            InitializeComponent();
            foreach (RaceCard raceCard in raceCards)
            {
                CmbRaceCard.Items.Add(raceCard);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RaceDay raceDay=new RaceDay();

            {
                raceDay.Name=TxtRaceDayName.Text;
                raceDay.Date=DTPRaceDay.Value;
                raceDay.RaceCards=CmbRaceCard.SelectedItem as List<RaceCard>;
            }
            LstRaceDay.Items.Add(raceDay);
        }
    }
}
