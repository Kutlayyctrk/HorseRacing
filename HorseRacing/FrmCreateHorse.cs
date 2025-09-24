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
            DgvHorses.DataSource = _horses;


        }

        private void BtnCreateHorse_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrWhiteSpace(TxtHorseName.Text) || string.IsNullOrWhiteSpace(TxtHorseRegion.Text))
                {
                    MessageBox.Show("Required fields must be filled out!");
                    return; 
                }

                if (CmbJockey.SelectedItem == null)
                {
                    MessageBox.Show("Required fields must be filled out!");
                    return ;
                }
                
                if (int.TryParse(TxtHorsaAge.Text, out int age))
                {
                    Horse horse = new Horse(TxtHorseName.Text, age, TxtHorseRegion.Text, CmbJockey.SelectedItem as Jockey);
                    _horses.Add(horse);
                    DgvHorses.DataSource = null;
                    DgvHorses.DataSource = _horses;

                   
                    TxtHorsaAge.Text = "";
                    TxtHorseName.Text = "";
                    TxtHorseRegion.Text = "";
                    CmbJockey.Text = "";

                    MessageBox.Show($"Horse has been created named by: {horse.Name}");
                }
                else
                {
                   
                    MessageBox.Show("Please enter a valid age.");
                    return; 
                }

               
                

            }
            catch (Exception ex)
            {
               
                MessageBox.Show(ex.Message);
            }
        }


    }
}
