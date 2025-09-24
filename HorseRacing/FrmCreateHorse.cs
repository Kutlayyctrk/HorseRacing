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
    public partial class FrmCreateHorse : FrmBase
    {
        private List<Horse> _horses;
        public FrmCreateHorse(List<Horse> horses, List<Jockey> jockeys)
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
            if (CmbJockey.SelectedItem == null)
            {
                MessageBox.Show("Jokey Kısmı Boş Bırakılamaz.");
                return;
            }

            else
            {
                Horse horse = new Horse(TxtHorseName.Text, Convert.ToInt32(TxtHorsaAge.Text), TxtHorseRegion.Text, CmbJockey.SelectedItem as Jockey);
                _horses.Add(horse);
                TxtHorsaAge.Text = "";
                TxtHorseName.Text = "";
                TxtHorseRegion.Text = "";
                CmbJockey.Text = "";
                MessageBox.Show($"{horse.Name.ToString()} Adında Bir  At Oluşturuldu");
            }
        }


    }
}
