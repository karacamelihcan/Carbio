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
    public partial class Customer_Homepage : Form
    {
        public Customer_Homepage()
        {
            InitializeComponent();
        }

        private void araçlarıGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Car_Information cı = new Car_Information();
            cı.Show();
            this.Close();
        }

        private void motorlarIGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Motor_Information mı = new Motor_Information();
            mı.Show();
            this.Close();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            First_Select_Entering fse = new First_Select_Entering();
            fse.Show();
            this.Close();
        }
    }
}
