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
            CmbHorse.DisplayMember = "Name";
            foreach (Horse horse in horses)
            {
                CmbHorse.Items.Add(horse);
            }
            CmbRaceCard.DisplayMember = "Name";
            foreach (RaceCard raceCard in raceCards)
            {
                CmbRaceCard.Items.Add(raceCard);
            }
            _races = races;
        }

        private void BtnAddHorse_Click(object sender, EventArgs e)
        {
            LstSelectedHorse.DisplayMember = "Name";
            if (CmbHorse.SelectedItem != null)
            {
                LstSelectedHorse.Items.Add(CmbHorse.SelectedItem);
            }
            else
            {
                MessageBox.Show("Eklemek için Bir At Seçmesilisiniz.");
                return;
            }
        }

        private void BtnDeleteHorse_Click(object sender, EventArgs e)
        {
            if (LstSelectedHorse.SelectedItem != null)
            {
                LstSelectedHorse.Items.Remove(LstSelectedHorse.SelectedItem);
            }
            else
            {
                MessageBox.Show("Silmek İçin Bir At Seçmelisiniz.");
            }
        }

        private void BtnCreateRace_Click(object sender, EventArgs e)
        {
            if (CmbRaceCard.SelectedItem == null || LstSelectedHorse.Items.Count < 1)
            {
                if (CmbRaceCard.SelectedItem == null)
                {
                    MessageBox.Show("Önce Bir Bülten Seçmelisiniz");
                }
                else
                {
                    MessageBox.Show("Yarış içerisine Atları eklemelisiniz");
                }
            }
            else
            {
                List<Horse> selectedHorse = new List<Horse>();
                foreach (Horse horse in LstSelectedHorse.Items)
                {
                    selectedHorse.Add(horse);
                }

                Race race = new Race
                {
                    Name = TxtRaceName.Text,
                    RaceCard = CmbRaceCard.SelectedItem as RaceCard,
                    Horses = selectedHorse
                };

                
                RaceCard selectedRaceCard = CmbRaceCard.SelectedItem as RaceCard;

                if (selectedRaceCard != null)
                {
                    if (selectedRaceCard.Races == null)
                    {
                        selectedRaceCard.Races = new List<Race>();
                    }
                    selectedRaceCard.Races.Add(race);
                }

                _races.Add(race);

                TxtRaceName.Text = "";
                CmbHorse.Text = "";
                CmbRaceCard.Text = "";
                LstSelectedHorse.Items.Clear();

                MessageBox.Show($"{race.Name.ToString()} Adında Bir Yarış Oluşturuldu.");
            }
        }
    }
}