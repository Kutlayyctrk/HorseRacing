using HorseRacing.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseRacing
{
    public partial class FrmHorseAddOrEdit : FrmBase
    {
        private BindingList<Horse> _horses;
        private BindingList<Jockey> _jockeys;
        private BindingList<Race> _races;
        private Horse _currentHorse;
        public FrmHorseAddOrEdit(BindingList<Jockey> jockeys, BindingList<Race> races,BindingList<Horse>horses,Horse editHorse)
        {
            InitializeComponent();
            _jockeys = jockeys;
            _races = races;
            _horses = horses;
            _currentHorse = editHorse;
            Text = $"Edit To {editHorse.Name}";
            BtnAddOrEdit.Text = "Edit";
        
            HorseData();

            
        }

        public  FrmHorseAddOrEdit(BindingList<Jockey>jockeys,BindingList<Horse>horses)
        {
            InitializeComponent();
            _jockeys=jockeys;
            _horses=horses;
            _currentHorse=new Horse();
            Text = "Add new Jockey";
            BtnAddOrEdit.Text = "Save";
            foreach (Jockey jockey in _jockeys)
            {
                CmbJockey.Items.Add(jockey);
            } 


             
        }

        private void HorseData()
        {
            TxtHorseAge.Text=_currentHorse.Age.ToString();
            TxtHorseName.Text=_currentHorse.Name;
            TxtHorseRegion.Text=_currentHorse.Region;
            foreach (Jockey jockey in _jockeys)
            {
                CmbJockey.Items.Add(jockey);
            }
            CmbJockey.SelectedItem = _currentHorse;
        }

        private void BtnAddOrEdit_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(TxtHorseName.Text))
                {
                    MessageBox.Show("Horse name cannot be empty");
                    return;
                    
                }
                if(!int.TryParse(TxtHorseAge.Text,out int age))
                {
                    MessageBox.Show("Horse age must be a number");
                    return;
                }
                if(string.IsNullOrWhiteSpace(TxtHorseRegion.Text))
                {
                    MessageBox.Show("Horse region cannot be empty");
                    return;
                }
                _currentHorse.Age = age;
                _currentHorse.Name=TxtHorseName.Text;
                _currentHorse.Region=TxtHorseRegion.Text;
                _currentHorse.Jockey = CmbJockey.SelectedItem as Jockey;

                if(_currentHorse.Id==0)
                {
                    Horse horse = new Horse(_currentHorse.Name, _currentHorse.Age, _currentHorse.Region,_currentHorse.Jockey);
                    _horses.Add(horse);
                    TxtHorseAge.Text = string.Empty;
                    TxtHorseName.Text = string.Empty;
                    TxtHorseRegion.Text = string.Empty;
                    CmbJockey.Text=string.Empty;
                    TxtHorseName.Focus();
                    MessageBox.Show($"Horse has been succesfull created:{_currentHorse.Name}");
                }
                else
                {
                    MessageBox.Show($"Horse has been succesfully updated:{_currentHorse.Name}");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return;
            }
        }

      
    }
}
