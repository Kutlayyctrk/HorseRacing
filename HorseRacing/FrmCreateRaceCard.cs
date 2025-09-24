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
    public partial class FrmCreateRaceCard : FrmBase
    {
        private List<RaceCard> _raceCards;

        public FrmCreateRaceCard(List<Race> races, List<RaceDay> raceDays, List<RaceCard> raceCards)
        {
            InitializeComponent();

            CmbRaceDays.DisplayMember = "Name";
            foreach (RaceDay raceDay in raceDays)
            {
                CmbRaceDays.Items.Add(raceDay);
            }
            _raceCards = raceCards;

        }





        private void BtnCreateRaceCard_Click(object sender, EventArgs e)
        {

            RaceCard raceCard = new RaceCard();
            {
                raceCard.Name = TxtRaceCardName.Text;
                raceCard.Place = TxtRaceCardPlace.Text;
                raceCard.raceDay = CmbRaceDays.SelectedItem as RaceDay;
            }
            RaceDay selectedRaceDay = CmbRaceDays.SelectedItem as RaceDay;

            if (selectedRaceDay != null)
            {
                if (selectedRaceDay.RaceCards == null)
                {
                    selectedRaceDay.RaceCards = new List<RaceCard>();
                }
                selectedRaceDay.RaceCards.Add(raceCard);
            }
            _raceCards.Add(raceCard);
            MessageBox.Show($"{raceCard.Name.ToString()} Adında Bir Bülten Oluşturdunuz.");
        }
    }
}
