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
    public partial class FrmJockeyAddOrEdit : FrmBase
    {
        private BindingList<Jockey> _jockeys;
        private Jockey _currentJockey;          
        public FrmJockeyAddOrEdit(BindingList<Jockey>jockeys)//İlk ekleme yaparken acılacak form constructor'ı
        {
            InitializeComponent();
            _jockeys = jockeys;
            _currentJockey=new Jockey();
            Text = "Add New Jockey";
            BtnSave.Text = "Save";
        }
       
        public FrmJockeyAddOrEdit(BindingList<Jockey> jockeys, Jockey editJockey) //Edit için 2.Consturctor yaratıp isim ve veri düzenlemesini yapıyorum jockeydata metodu ile.
        {
            InitializeComponent();
            _jockeys=jockeys;
            _currentJockey=editJockey;
            Text=$"Edit To {editJockey.Name}";
            BtnSave.Text = "Edit";
            JockeyData();
        }

        private void JockeyData()//Düzenlemesi yapılacak nesnenin verilerini textboxlara aktarıyor.
        {
            TxtJockeyAge.Text=_currentJockey.Age.ToString();
            TxtJockeyName.Text=_currentJockey.Name;
        }
       
        

       

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtJockeyName.Text))
                {
                    MessageBox.Show("Jockey name cannot be empty.");
                    return;
                }
                if (!int.TryParse(TxtJockeyAge.Text, out int age))
                {
                    MessageBox.Show("Jockey age must be a number!");
                    return;

                }
                _currentJockey.Name = TxtJockeyName.Text;
                _currentJockey.Age = age;
                
                if(_currentJockey.Id==0)
                {
                    Jockey jockey=new Jockey(_currentJockey.Name,_currentJockey.Age);
                    _jockeys.Add(jockey);
                    MessageBox.Show($"Jockey has been succesfully created: {_currentJockey.Name}");
                    TxtJockeyAge.Text=string.Empty;
                    TxtJockeyName.Text=string.Empty;
                    TxtJockeyName.Focus();

                }
                else
                {
                    MessageBox.Show($"Jockey has been successfully updated: {_currentJockey.Name}");
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
