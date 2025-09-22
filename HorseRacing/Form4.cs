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
    public partial class Form4 : Form
    {
        public Form4(List<Race> races)
        {
            InitializeComponent();
            foreach (Race race in races)
            {
                cmbRace.Items.Add(race);
            }

        }
        List<RaceCard>raceCards = new List<RaceCard>();
        private void BtnRaceCard_Click(object sender, EventArgs e)
        {
            RaceCard raceCard = new RaceCard()
            {
                Name = TxtRaceCardName.Text,
                Place = TxtRaceCardPlace.Text,
                Races = cmbRace.SelectedItem as List<Race>
            };
            
            raceCards.Add(raceCard);
        }

        private void BtnRaceDay_Click(object sender, EventArgs e)
        {
            Form5 fr = new Form5(raceCards);
            fr.ShowDialog();
            this.Close();
        }
    }
}
