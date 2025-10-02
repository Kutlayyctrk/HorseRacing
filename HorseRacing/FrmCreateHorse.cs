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
        private BindingList<Horse> _horses;
        public FrmCreateHorse(BindingList<Horse> horses, BindingList<Jockey> jockeys)
        {
            InitializeComponent();
            
            foreach (Jockey jockey in jockeys)
            {
                CmbJockey.Items.Add(jockey);
            }
           _horses=new BindingList<Horse>(horses);
            DgvHorses.DataSource =_horses;


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
                    DgvHorses.DataSource = _horses;


                    TxtHorsaAge.Text = string.Empty;
                    TxtHorseName.Text = string.Empty ;
                    TxtHorseRegion.Text =string.Empty ;
                    CmbJockey.SelectedItem = string.Empty ;
                   

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

        private void FrmCreateHorse_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "Delete";
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "Edit";
            editButtonColumn.HeaderText = "Edit";
            editButtonColumn.Text = "Edit";
            editButtonColumn.UseColumnTextForButtonValue = true;
            DgvHorses.Columns.Add(deleteButtonColumn);
            DgvHorses.Columns.Add(editButtonColumn);
           
        }
    }
}
