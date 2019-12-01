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
    public partial class First_Select_Entering : Form
    {
        public First_Select_Entering()
        {
            InitializeComponent();
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            Manager_Login mg = new Manager_Login();
            mg.Show();
            this.Close();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Personel_Login pl = new Personel_Login();
            pl.Show();
            this.Close();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Customer_Logın cl = new Customer_Logın();
            cl.Show();
            this.Close();
        }
    }
}
