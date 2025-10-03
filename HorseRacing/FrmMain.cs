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

        private BindingList<RaceCard> _raceCards = new BindingList<RaceCard>();
        private BindingList<Race> _races = new BindingList<Race>();
        private BindingList<Horse> _horses = new BindingList<Horse>();
        private BindingList<Jockey> _jockeys = new BindingList<Jockey>();
        private BindingList<RaceDay> _raceDays = new BindingList<RaceDay>();
        private BindingList<AllData> _allData = new BindingList<AllData>();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnCreateJockey_Click(object sender, EventArgs e)
        {
            FrmCreateJockey c1 = new FrmCreateJockey(_jockeys,_horses);
            c1.Show();
        }

        private void BtnCreateHorse_Click(object sender, EventArgs e)
        {
            if (_jockeys.Count == 0)
            {
                MessageBox.Show("You must create a Jockey first.");
                return;
            }
            else
            {
                FrmCreateHorse c1 = new FrmCreateHorse(_horses, _jockeys);
                c1.Show();
            }
        }

        private void BtnCreateRace_Click(object sender, EventArgs e)
        {
            if (_horses.Count == 0 || _raceCards.Count == 0)
            {
                if (_horses.Count == 0)
                {
                    MessageBox.Show("You must create a Horse first.");
                }
                else if (_raceCards.Count == 0)
                {
                    MessageBox.Show("You must create a Bulletin first.");
                }
            }
            else
            {
                FrmCreateRace c1 = new FrmCreateRace(_horses, _raceCards, _races);
                c1.Show();
            }
        }

        private void BtnCreateRaceCard_Click(object sender, EventArgs e)
        {
            if (_raceDays.Count == 0)
            {
                MessageBox.Show("You must create a Race Day first");
                return;
            }
            FrmCreateRaceCard c1 = new FrmCreateRaceCard(_races, _raceDays, _raceCards);
            c1.Show();
        }

        private void BtnCreateRaceDay_Click(object sender, EventArgs e)
        {
            FrmCreateRaceDay c1 = new FrmCreateRaceDay(_raceCards, _raceDays);
            c1.Show();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LblInfo.Text = "*You must create a Jockey before creating a Horse.\n*You must create a Race Day before creating a Bulletin.\n*You must create a Bulletin and a Horse before creating a Race.\n*You can sequentially create a Jockey - Horse - Race Day - Bulletin - Race.";
        }

        private void BtnInformation_Click(object sender, EventArgs e)
        {
            FrmInformation i1 = new FrmInformation(_jockeys, _horses, _races, _raceCards, _raceDays, _allData);
            i1.Show();
        }
    }
}
