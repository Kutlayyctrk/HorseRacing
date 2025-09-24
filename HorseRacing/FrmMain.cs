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
    public partial class FrmMain : FrmBase
    {
        
        List<RaceCard> raceCards = new List<RaceCard>();
        List<Race> races = new List<Race>();
        List<Horse> horses = new List<Horse>();
        List<Jockey> jockeys = new List<Jockey>();
        List<RaceDay> raceDays = new List<RaceDay>();
        List<AllData> allData = new List<AllData>();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnCreateJockey_Click(object sender, EventArgs e)
        {
            FrmCreateJockey c1 = new FrmCreateJockey(jockeys);
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
                FrmCreateHorse c1 = new FrmCreateHorse(horses, jockeys);
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
                FrmCreateRace c1 = new FrmCreateRace(horses, raceCards, races);
                c1.Show();
            }
        }

        private void BtnCreateRaceCard_Click(object sender, EventArgs e)
        {
            if (raceDays.Count==0)
            {
                MessageBox.Show("Önce Bir Yarış Günü yaratmalsınız");
                return;
            }
            FrmCreateRaceCard c1 = new FrmCreateRaceCard(races, raceDays, raceCards);
            c1.Show();
        }

        private void BtnCreateRaceDay_Click(object sender, EventArgs e)
        {
            FrmCreateRaceDay c1 = new FrmCreateRaceDay(raceCards, raceDays);
            c1.Show();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LblInfo.Text = "*At Yaratmadan Önce Jokey Yaratmalısınız\n*Bülten Yaratmadan Önce Yarış Günü Yaratmalısınız.\n*Koşu  Yaratmadan Önce Bülten ve At Yaratmalısınız.\n*Sırasıyla Jokey - At - Yarış Günü - Bülten - Yarış Oluşturabilirsiniz.";
        }

        private void BtnInformation_Click(object sender, EventArgs e)
        {
            FrmInformation i1 = new FrmInformation(jockeys,horses,races,raceCards,raceDays,allData);
            i1.Show();
        }
    }
}
