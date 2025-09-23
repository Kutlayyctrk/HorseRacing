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
    public partial class CreateRace : Form
    {
        private List<Race> _races = new List<Race>();
        public CreateRace(List<Horse> horses, List<RaceCard> raceCards, List<Race> races)
        {

            InitializeComponent();
            foreach (Horse horse in horses)
            {
                CmbHorse.Items.Add(horse);
            }
            foreach (RaceCard raceCard in raceCards)
            {
                CmbRaceCard.Items.Add(raceCard);
            }
            _races = races;
        }

        private void BtnAddHorse_Click(object sender, EventArgs e)
        {
            if (CmbHorse.SelectedItem != null)
            {
                LstSelectedHorse.Items.Add(CmbHorse.SelectedItem);
            }
        }

        private void BtnDeleteHorse_Click(object sender, EventArgs e)
        {
            if (LstSelectedHorse.SelectedItem != null)
            {
                LstSelectedHorse.Items.Remove(LstSelectedHorse.SelectedItem);
            }
        }

        private void BtnCreateRace_Click(object sender, EventArgs e)
        {
            List<Horse> selectedHorse = new List<Horse>();
            foreach (Horse horse in LstSelectedHorse.Items)
            {
                selectedHorse.Add(horse);
            }

            Race race = new Race();
            {
                race.Name = TxtRaceName.Text;
                race.RaceCard = CmbRaceCard.SelectedItem as RaceCard;
                race.Horses = selectedHorse;

            }
            _races.Add(race);
        }
    }
}
