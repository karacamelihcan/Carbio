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
    public partial class Personel_Login : Form
    {
        public Personel_Login()
        {
            InitializeComponent();
        }

        private void btnRegistergLogIn_Click(object sender, EventArgs e)
        {
            Personel_Register pr = new Personel_Register();
            pr.Show();
            this.Close();
        }
    }
}
