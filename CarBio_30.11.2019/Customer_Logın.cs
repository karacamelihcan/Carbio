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
    public partial class Customer_Logın : Form
    {
        public Customer_Logın()
        {
            InitializeComponent();
        }

        private void btnRegisterLogIn_Click(object sender, EventArgs e)
        {
            Customer_Register cr = new Customer_Register();
            cr.Show();
            this.Close();
        }
    }
}
