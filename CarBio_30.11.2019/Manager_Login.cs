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
    public partial class Manager_Login : Form
    {
        public Manager_Login()
        {
            InitializeComponent();
        }

        private void btnSıgnIn_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistergLogIn_Click(object sender, EventArgs e)
        {
            Manager_Register mr = new Manager_Register();
            mr.Show();
            this.Hide();
        }
    }
}
