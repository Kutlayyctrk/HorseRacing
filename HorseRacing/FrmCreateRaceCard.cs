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
        private BindingList<RaceCard> _raceCards;

        public FrmCreateRaceCard(BindingList<Race> races, BindingList<RaceDay> raceDays, BindingList<RaceCard> raceCards)
        {
            InitializeComponent();


            foreach (RaceDay raceDay in raceDays)
            {
                CmbRaceDays.Items.Add(raceDay);
            }
            _raceCards = new BindingList<RaceCard>(raceCards);
            dgvRaceCards.DataSource = raceCards;

        }





        private void BtnCreateRaceCard_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtRaceCardName.Text) || string.IsNullOrWhiteSpace(TxtRaceCardPlace.Text))
                {
                    MessageBox.Show("Required fields must be filled out!");
                    return;
                }
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

                    dgvRaceCards.DataSource = _raceCards;
                }
                _raceCards.Add(raceCard);

                dgvRaceCards.DataSource = _raceCards;
                MessageBox.Show($"Racecard has been created named by:" + Environment.NewLine + raceCard.Name);
                TxtRaceCardName.Text = string.Empty;
                TxtRaceCardPlace.Text = string.Empty;
                CmbRaceDays.SelectedItem = null;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
