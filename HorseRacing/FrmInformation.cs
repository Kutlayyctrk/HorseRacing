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
    public partial class FrmInformation : FrmBase
    {
        private BindingList<Horse> _horses;
        private BindingList<Race> _races;
        private BindingList<RaceCard> _raceCards;
        private BindingList<RaceDay> _raceDays;
        private BindingList<Jockey> _jockeys;
        private BindingList<AllData> _allData;
        public FrmInformation(BindingList<Jockey> jokeys, BindingList<Horse> horses, BindingList<Race> races, BindingList<RaceCard> raceCards, BindingList<RaceDay> raceDays, BindingList<AllData> allDatas)
        {
            InitializeComponent();
            _jockeys = new BindingList<Jockey>(jokeys);
            _horses = new BindingList<Horse>(horses);
            _races = new BindingList<Race>(races);
            _raceCards = new BindingList<RaceCard>(raceCards);
            _raceDays = new BindingList<RaceDay>(raceDays);
            _allData = new BindingList<AllData>(allDatas);
            DgvRaceDay.DataSource = raceDays;
            DgvRaceDay.CellClick += DgvRaceDay_CellClick;
            dgvRaceCard.CellClick += dgvRaceCard_CellClick;
            dgvRace.CellClick += dgvRace_CellClick;



        }

        private void DgvRaceDay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            RaceDay raceDay = DgvRaceDay.Rows[e.RowIndex].DataBoundItem as RaceDay;

            if (raceDay != null)
            {

                dgvRaceCard.DataSource = _raceCards;
            }

        }

        private void dgvRaceCard_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            RaceCard raceCard = dgvRaceCard.Rows[e.RowIndex].DataBoundItem as RaceCard;
            if (raceCard != null)
            {

                dgvRace.DataSource = _races;
            }



        }

        private void dgvRace_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            Race race = dgvRace.Rows[e.RowIndex].DataBoundItem as Race;
            if (race != null)
            {

                dgvHorse.DataSource = _horses;
            }

        }


    }
}
