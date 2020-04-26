using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VasaviMedicals
{
    public partial class Admin_Home : Form
    {
        public Admin_Home()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_StockEntry adse = new Admin_StockEntry();
            adse.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_TotalReport tr = new Admin_TotalReport();
            tr.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Logout al = new Admin_Logout();
            al.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_SaleEntry adse = new Admin_SaleEntry();
            adse.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_VendorDetails avd = new Admin_VendorDetails();
            avd.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_GSTAmount ags = new Admin_GSTAmount();
            ags.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_ReturnProduct ar = new Admin_ReturnProduct();
            ar.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_BackUp ab = new Admin_BackUp();
            ab.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Restore ar = new Admin_Restore();
            ar.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Admin_LoginCreation ac = new Admin_LoginCreation();
            ac.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Ledgerr al = new Admin_Ledgerr();
            al.ShowDialog();
        }

        private void Admin_Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("Do You Really Want To Close?", "Exit", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else if (d == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
