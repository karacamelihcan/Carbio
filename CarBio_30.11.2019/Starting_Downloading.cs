using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarBio_30._11._2019
{
    public partial class Starting_Downloading : Form
    {
        public Starting_Downloading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 30;
            if (progressBar1.Value == 120)
            {
                timer1.Stop();

                First_Select_Entering ft = new First_Select_Entering();
                ft.Show();
                this.Hide();

            }
        }
    }
}
