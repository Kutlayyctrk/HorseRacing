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
    public partial class CreateRaceCard : Form
    {
        private List<RaceCard> _raceCards;
        private List<Race> _races;
        public CreateRaceCard(List<Race> races, List<RaceDay> raceDays, List<RaceCard> raceCards)
        {
            InitializeComponent();
            CmbRaces.DisplayMember = "Name";
            foreach (Race race in races)
            {
                CmbRaces.Items.Add(race);
            }
            CmbRaceDays.DisplayMember = "Name";
            foreach (RaceDay raceDay in raceDays)
            {
                CmbRaceDays.Items.Add(raceDay);
            }
            _raceCards = raceCards;
            _races=races;
        }

        private void BtnAddRace_Click(object sender, EventArgs e)
        {
            if (CmbRaces.SelectedItem != null)
            {
                LstSelectedRace.Items.Add(CmbRaces.SelectedItem);
            }

        }

        private void BtnRemoveRace_Click(object sender, EventArgs e)
        {
            if (LstSelectedRace.SelectedItem != null)
            {
                LstSelectedRace.Items.Remove(LstSelectedRace.SelectedItem);
            }

        }

        private void BtnCreateRaceCard_Click(object sender, EventArgs e)
        {
            List<Race> selectedRace = new List<Race>();
            foreach (Race race in LstSelectedRace.Items)
            {
                selectedRace.Add(race);
            }
            RaceCard raceCard = new RaceCard();
            {
                raceCard.Name = TxtRaceCardName.Text;
                raceCard.Place = TxtRaceCardPlace.Text;
                raceCard.Races = selectedRace;
                raceCard.raceDay = CmbRaceDays.SelectedItem as RaceDay;
            }
            _raceCards.Add(raceCard);
        }
    }
}
