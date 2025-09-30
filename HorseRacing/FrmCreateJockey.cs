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

    public partial class FrmCreateJockey : FrmBase
    {
        private BindingList<Jockey> _jockeys;
        public FrmCreateJockey(List<Jockey> jockeys)
        {
            InitializeComponent();
            _jockeys = new BindingList<Jockey>(jockeys);
            dgvJockeys.DataSource = _jockeys;
        }
        private void BtnCreateJockey_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtJockeyName.Text))
                {
                    MessageBox.Show("Jockey name cannot be empty.");
                    return;
                }
                if (int.TryParse(TxtJockeyAge.Text, out int age))
                {
                    Jockey jockey = new Jockey(TxtJockeyName.Text, age);
                    _jockeys.Add(jockey);
                    MessageBox.Show($"Jockey has been created named by : "+Environment.NewLine +jockey.Name);
                    TxtJockeyAge.Text = string.Empty;
                    TxtJockeyName.Text = string.Empty;
                    TxtJockeyName.Focus();
                }
                else
                {
                    MessageBox.Show("Jockey age must be a number!");
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
