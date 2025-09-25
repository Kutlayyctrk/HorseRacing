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
        private List<Horse> _horses;
        private List<Race> _races;
        private List<RaceCard> _raceCards;
        private List<RaceDay> _raceDays;
        private List<Jockey> _jockeys;
        private List<AllData> _allData;
        public FrmInformation(List<Jockey> jokeys, List<Horse> horses, List<Race> races, List<RaceCard> raceCards, List<RaceDay> raceDays, List<AllData> allDatas)
        {
            InitializeComponent();
            _jockeys = jokeys;
            _horses = horses;
            _races = races;
            _raceCards = raceCards;
            _raceDays = raceDays;
            _allData = allDatas;
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
                _raceCards = raceDay.RaceCards;
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
                _races = raceCard.Races;
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
                _horses = race.Horses;
                dgvHorse.DataSource = _horses;
            }

        }


    }
}
