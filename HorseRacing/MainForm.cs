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
    public partial class MainForm : Form
    {

        List<RaceCard> raceCards = new List<RaceCard>();
        List<Race> races = new List<Race>();
        List<Horse> horses = new List<Horse>();
        List<Jockey> jockeys = new List<Jockey>();
        List<RaceDay> raceDays = new List<RaceDay>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnCreateJockey_Click(object sender, EventArgs e)
        {
            CreateJockey c1 = new CreateJockey(jockeys);
            c1.Show();
        }

        private void BtnCreateHorse_Click(object sender, EventArgs e)
        {
            if (jockeys.Count == 0)
            {
                MessageBox.Show("Önce Jokey Oluşturulmalısınız.");
                return;
            }
            else
            {
                CreateHorse c1 = new CreateHorse(horses, jockeys);
                c1.Show();
            }
        }

        private void BtnCreateRace_Click(object sender, EventArgs e)
        {
            if (horses.Count == 0 || raceCards.Count == 0)
            {
                if (horses.Count == 0)
                {
                    MessageBox.Show("Önce Bir At Oluşturmalısınız");
                }
                else if (raceCards.Count == 0)
                {
                    MessageBox.Show("Önce Bir Bülten Oluşturmalısınız");
                }
            }
            else
            {
                CreateRace c1 = new CreateRace(horses, raceCards, races);
                c1.Show();
            }
        }

        private void BtnCreateRaceCard_Click(object sender, EventArgs e)
        {
            CreateRaceCard c1 = new CreateRaceCard(races, raceDays, raceCards);
            c1.Show();
        }

        private void BtnCreateRaceDay_Click(object sender, EventArgs e)
        {
            CreateRaceDay c1 = new CreateRaceDay(raceCards, raceDays);
            c1.Show();

        }
    }
}
