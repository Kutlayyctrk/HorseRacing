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
    public partial class CreateRaceDay : Form
    {
        private List<RaceDay> _raceDays;
        public CreateRaceDay(List<RaceCard> raceCards, List<RaceDay> raceDays)
        {
            InitializeComponent();
            CmbRaceCards.DisplayMember = "Name";
            foreach (RaceCard raceCard in raceCards)
            {
                CmbRaceCards.Items.Add(raceCard);
            }
            _raceDays = raceDays;
        }

        private void BtnAddRaceCard_Click(object sender, EventArgs e)
        {
            LstRaceCards.DisplayMember = "Name";
            if (CmbRaceCards.SelectedItem != null)
            {
                LstRaceCards.Items.Add(CmbRaceCards.SelectedItem);
            }
        }

        private void BtnDeleteRaceCard_Click(object sender, EventArgs e)
        {
            if (LstRaceCards.SelectedItem != null)
            {
                LstRaceCards.Items.Remove(LstRaceCards.SelectedItem);
            }
        }

        private void BtnCreateRaceDay_Click(object sender, EventArgs e)
        {
            List<RaceCard> selectedRaceCards = new List<RaceCard>();
            foreach (RaceCard raceCard in selectedRaceCards)
            {
                selectedRaceCards.Add(raceCard);
            }
            RaceDay raceDay = new RaceDay();
            {
                raceDay.Name = TxtRaceDayName.Text;
                raceDay.Date = DTPRaceDay.Value;
                raceDay.RaceCards = selectedRaceCards;

            }
            _raceDays.Add(raceDay);
        }
    }
}
