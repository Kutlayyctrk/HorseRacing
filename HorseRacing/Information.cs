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
    public partial class Information : Form
    {
        private List<Horse> _horses;
        private List<Race> _races;
        private List<RaceCard> _raceCards;
        private List<RaceDay> _raceDays;
        private List<Jockey> _jockeys;
        private List<AllData> _allData
        public Information(List<Jockey> jokeys, List<Horse> horses, List<Race> races, List<RaceCard> raceCards, List<RaceDay> raceDays,List<AllData>allDatas)
        {
            InitializeComponent();
            _jockeys = jokeys;
            _horses = horses;
            _races = races;
            _raceCards = raceCards;
            _raceDays = raceDays;
            _allData = allDatas;
        }

        
    }
}
