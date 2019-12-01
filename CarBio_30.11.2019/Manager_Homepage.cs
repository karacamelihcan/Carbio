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
    public partial class Manager_Homepage : Form
    {
        public Manager_Homepage()
        {
            InitializeComponent();
        }

        private void personelGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personel_Information pı = new Personel_Information();
            pı.Show();
        }

        private void personelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personel_Register pr = new Personel_Register();
            pr.Show();

        }

        private void personelCıkarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personel_Delete pd = new Personel_Delete();
            pd.Show();
        }

        private void personelBilgisiDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personel_Edit pe = new Personel_Edit();
            pe.Show();
        }

        private void müsteriBilgileriGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer_Information cı = new Customer_Information();
            cı.Show();

        }

        private void müsteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer_Register cr = new Customer_Register();
            cr.Show();

        }

        private void aracGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Car_Information cı = new Car_Information();
            cı.Show();
        }

        private void aracEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Car_Add ca = new Car_Add();
            ca.Show();
        }

        private void aracCıkarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Car_Delete cd = new Car_Delete();
            cd.Show();
        }

        private void aracBilgisiniDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Car_Edit ce = new Car_Edit();
            ce.Show();
        }

        private void motorGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Motor_Information mı = new Motor_Information();
            mı.Show();
        }

        private void motorEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Motor_Add ma = new Motor_Add();
            ma.Show();
        }

        private void motorcıkarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Motor_Delete md = new Motor_Delete();
            md.Show();
        }

        private void motorBilgileriDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Motor_Edit me = new Motor_Edit();
            me.Show();
        }

        private void cıkısToolStripMenuItem_Click(object sender, EventArgs e)
        {
            First_Select_Entering fse = new First_Select_Entering();
            fse.Show();
            this.Close();
        }

        private void müsteriCıkarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer_Delete cst = new Customer_Delete();
            cst.Show();
        }
    }
}
