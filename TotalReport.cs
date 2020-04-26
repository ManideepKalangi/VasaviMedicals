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

    public partial class TotalReport : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\vsms.mdf;Integrated Security=True");
        
        public TotalReport()
        {
            InitializeComponent();
        }
        private void TotalReport_Load(object sender, EventArgs e)
        {
            conn.Open();
            string query1 = "select Sum([Total Price]) from Avail_stock";
            SqlDataAdapter sda1 = new SqlDataAdapter(query1, conn);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            string query2 = "select Sum([Total Price]) from Sale_data";
            SqlDataAdapter sda2 = new SqlDataAdapter(query2, conn);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            string a = DateTime.Now.ToLongDateString();
            string query3 = "select Sum([Total Price]) from Sale_data where [Sale Date]='" + a + "'";
            SqlDataAdapter sda3 = new SqlDataAdapter(query3, conn);
            DataTable dt3 = new DataTable();
            sda2.Fill(dt3);

            label5.Text = dt1.Rows[0][0].ToString();
            label7.Text = dt2.Rows[0][0].ToString();
            label4.Text = dt3.Rows[0][0].ToString();
            conn.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.ShowDialog();
        }

        private void TotalReport_FormClosing(object sender, FormClosingEventArgs e)
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
