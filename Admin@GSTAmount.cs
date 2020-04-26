using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace VasaviMedicals
{
    public partial class Admin_GSTAmount : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\vsms.mdf;Integrated Security=True");

        public Admin_GSTAmount()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Home h = new Admin_Home();
            h.ShowDialog();
        }

        private void Admin_GSTAmount_Load(object sender, EventArgs e)
        {
            string query = "select Sum([Total Price]) from Sale_data";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string query1 = "select Sum([Total Price]*[GST]) from Medicine_details";
            SqlDataAdapter sda1 = new SqlDataAdapter(query1, conn);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            label4.Text =dt.Rows[0][0].ToString();
            label6.Text = dt1.Rows[0][0].ToString();
        }

        private void Admin_GSTAmount_FormClosing(object sender, FormClosingEventArgs e)
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
