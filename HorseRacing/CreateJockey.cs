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
    
    public partial class CreateJockey : Form
    {
        private List<Jockey> _jockeys;
        public CreateJockey(List<Jockey> jockeys)
        {
            InitializeComponent();
            _jockeys = jockeys;
        }

        private void BtnCreateJockey_Click(object sender, EventArgs e)
        {
            Jockey jockey = new Jockey(TxtJockeyName.Text, Convert.ToInt32(TxtJockeyAge.Text));
            _jockeys.Add(jockey);
            TxtJockeyAge.Text = "";
            TxtJockeyName.Text = "";
            MessageBox.Show($"{jockey.Name.ToString()} Adında bir Jokey Oluşturuldu");
        }
    }
}
