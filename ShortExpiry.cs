using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading;

namespace VasaviMedicals
{
    public partial class ShortExpiry : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\vsms.mdf;Integrated Security=True");

        public ShortExpiry()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.ShowDialog();
        }

        private void ShortExpiry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vsmsDataSet.Avail_stock' table. You can move, or remove it, as needed.
            this.avail_stockTableAdapter1.Fill(this.vsmsDataSet.Avail_stock);
           
            string query = "select * from Avail_stock where [Quantity]>=1";
            SqlCommand sql = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(sql);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            avail_stockDataGridView.DataSource = dt;

            expiry_DateTextBox.Text = "";
        }

        private void ShortExpiry_FormClosing(object sender, FormClosingEventArgs e)
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

        private void expiry_DateTextBox_TextChanged(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            if (expiry_DateTextBox.Text != "")
            {
                int a = Convert.ToInt32(expiry_DateTextBox.Text);
                string query1 = "select * from Avail_stock where (([Expiry Date]) like '%" + a + "%') AND [Quantity]>=1";
                SqlCommand sql1 = new SqlCommand(query1, conn);
                SqlDataAdapter sda1 = new SqlDataAdapter(sql1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                avail_stockDataGridView.DataSource = dt1;
            }
            else
            {
                string query = "select * from Avail_stock where [Quantity]>=1";
                SqlCommand sql = new SqlCommand(query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                avail_stockDataGridView.DataSource = dt;
            }
        }
    }
}
