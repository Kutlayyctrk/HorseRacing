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
    public partial class Form2 : Form
    {
        public Form2(List<Jockey> jokeyler)
        {
            InitializeComponent();
            foreach (Jockey jokey in jokeyler)
            {
                cmbJockey.Items.Add(jokey);
            }

        }
        List<Horse> Horses = new List<Horse>();

        private void button1_Click(object sender, EventArgs e)
        {
            Horse horse = new Horse(TxtHorseName.Text, Convert.ToInt32(TxtHorseAge.Text), TxtHorseRegion.Text, (cmbJockey.SelectedItem as Jockey));
            Horses.Add(horse);
        }

        private void BtnRace_Click(object sender, EventArgs e)
        {
            Form3 f3=new Form3(Horses);
            f3.ShowDialog();
            this.Close();
        }
    }
}
