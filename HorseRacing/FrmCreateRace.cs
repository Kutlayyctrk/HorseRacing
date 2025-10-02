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
    public partial class FrmCreateRace : FrmBase
    {
        private BindingList<Race> _races;
        public FrmCreateRace(BindingList<Horse> horses, BindingList<RaceCard> raceCards, BindingList<Race> races)
        {
            InitializeComponent();
           
            foreach (Horse horse in horses)
            {
                CmbHorse.Items.Add(horse);
            }
           
            foreach (RaceCard raceCard in raceCards)
            {
                CmbRaceCard.Items.Add(raceCard);
            }
            _races = new BindingList<Race>(races);
            dgvRaces.DataSource= _races;
        }

        private void BtnAddHorse_Click(object sender, EventArgs e)
        {
            try
            {
            if (CmbHorse.SelectedItem != null)
            {
                LstSelectedHorse.Items.Add(CmbHorse.SelectedItem);
            }
            else
            {
                MessageBox.Show("You must select a horse to add!");
                return;
            }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void BtnDeleteHorse_Click(object sender, EventArgs e)
        {
            try
            {

            if (LstSelectedHorse.SelectedItem != null)
            {
                LstSelectedHorse.Items.Remove(LstSelectedHorse.SelectedItem);
            }
            else
            {
                MessageBox.Show("You must select a horse to delete!");
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCreateRace_Click(object sender, EventArgs e)
        {
            try
            {
                if (CmbRaceCard.SelectedItem == null || LstSelectedHorse.Items.Count < 1)
                {
                    if (CmbRaceCard.SelectedItem == null)
                    {
                        MessageBox.Show("You must first select a newsletter.");
                    }
                    else
                    {
                        MessageBox.Show("You must add horses to the race.");
                    }
                }
                else
                {
                    List<Horse> selectedHorse = new List<Horse>();
                    foreach (Horse horse in LstSelectedHorse.Items)
                    {
                        selectedHorse.Add(horse);
                    }

                    Race race = new Race
                    {
                        Name = TxtRaceName.Text,
                        RaceCard = CmbRaceCard.SelectedItem as RaceCard,
                        Horses = selectedHorse
                    };


                    RaceCard selectedRaceCard = CmbRaceCard.SelectedItem as RaceCard;

                    if (selectedRaceCard != null)
                    {
                        if (selectedRaceCard.Races == null)
                        {
                            selectedRaceCard.Races = new List<Race>();
                        }
                        selectedRaceCard.Races.Add(race);
                    }

                    _races.Add(race);
                    
                    dgvRaces.DataSource = _races;

                    TxtRaceName.Text = string.Empty;
                    CmbHorse.SelectedItem = string.Empty;
                    CmbRaceCard.SelectedItem = string.Empty;
                    LstSelectedHorse.Items.Clear();

                    MessageBox.Show($"Race has been created name by:" + Environment.NewLine + race.Name);

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void FrmCreateRace_Load(object sender, EventArgs e)
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
            dgvRaces.Columns.Add(deleteButtonColumn);
            dgvRaces.Columns.Add(editButtonColumn);
        }
    }
}