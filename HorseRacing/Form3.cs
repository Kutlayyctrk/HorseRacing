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
    public partial class Form3 : Form
    {
        public Form3(List<Horse> horses)
        {
            InitializeComponent();
            foreach (Horse horse in horses)
            {
                CmbHorse.Items.Add(horse);
            }
        }
        List<Race> Races = new List<Race>();
        List<Horse> RaceHorse=new List<Horse>();
       
        private void BtnHorse_Click(object sender, EventArgs e)
        {
           LstSelectedHorse.Items.Add(CmbHorse.SelectedItem);
           
        }

        private void BtnRace_Click(object sender, EventArgs e)
        {
            foreach (Horse horse in RaceHorse)
            {
                RaceHorse.Add(horse);
            }
            Race race = new Race()
            {
                Name = TxtRaceName.Text,
                Horses = RaceHorse,

            };
            Races.Add(race);
        

        }

        private void BtnRaceCard_Click(object sender, EventArgs e)
        {
            Form4 f4=new Form4(Races);
            f4.ShowDialog();
            this.Close();
        }
    }
}
