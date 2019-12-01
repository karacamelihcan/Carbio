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
    public partial class Personel_Homepage : Form
    {
        public Personel_Homepage()
        {
            InitializeComponent();
        }

        private void müşteriBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer_Information cı = new Customer_Information();
            cı.Show();
            this.Close();
            
        }

        private void müşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer_Register cr = new Customer_Register();
            cr.Show();
            
        }

        private void araçGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Car_Information cı = new Car_Information();
            cı.Show();
        }

        private void araçEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Car_Add ca = new Car_Add();
            ca.Show();
        }

        private void araçÇıkarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Car_Delete cd = new Car_Delete();
            cd.Show();
        }

        private void araçBilgileriniDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Car_Edit ce = new Car_Edit();
            ce.Show();
        }

        private void motorİşlemleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Motor_Information mı = new Motor_Information();
            mı.Show();

        }

        private void motorEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Motor_Add ma = new Motor_Add();
            ma.Show();

        }

        private void motorÇıkarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Motor_Delete md = new Motor_Delete();
            md.Show();

        }

        private void motorBilgileriniDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Motor_Edit me = new Motor_Edit();
            me.Show();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            First_Select_Entering fse = new First_Select_Entering();
            fse.Show();
            this.Close();
        }
    }
}
