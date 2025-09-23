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
    public partial class CreateHorse : Form
    {
        private List<Horse> _horses;
        public CreateHorse(List<Horse> horses,List<Jockey> jockeys)
        {
            InitializeComponent();
            CmbJockey.DisplayMember = "Name";
            foreach (Jockey jockey in jockeys)
            {
                CmbJockey.Items.Add(jockey);    
            }
            _horses = horses;

           
        }

        private void BtnCreateHorse_Click(object sender, EventArgs e)
        {
            Horse horse = new Horse(TxtHorseName.Text,Convert.ToInt32(TxtHorsaAge.Text),TxtHorseRegion.Text,CmbJockey.SelectedItem as Jockey);
            _horses.Add(horse);
        }

        
    }
}
