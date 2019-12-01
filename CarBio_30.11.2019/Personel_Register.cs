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
    public partial class Personel_Register : Form
    {
        public Personel_Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Personel_Homepage ph = new Personel_Homepage();
            ph.Show();
            this.Close();
        }
    }
}
