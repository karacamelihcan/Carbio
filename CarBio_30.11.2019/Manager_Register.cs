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
    public partial class Manager_Register : Form
    {
        public Manager_Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Manager_Homepage mh = new Manager_Homepage();
            mh.Show();
            this.Close();
        }
    }
}
