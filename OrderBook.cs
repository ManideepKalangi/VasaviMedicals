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
    public partial class OrderBook : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\vsms.mdf;Integrated Security=True");

        public OrderBook()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.ShowDialog();
        }

        private void OrderBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vsmsDataSet.Avail_stock' table. You can move, or remove it, as needed.
            this.avail_stockTableAdapter1.Fill(this.vsmsDataSet.Avail_stock);
            dealer_NameTextBox.Text = "";
            product_NameTextBox.Text = "";
            
            string query = "select * from Avail_stock where [Quantity]=0";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            avail_stockDataGridView.DataSource = dt;
        }

        private void product_NameTextBox_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            if (product_NameTextBox.Text != null)
            {
                string a = product_NameTextBox.Text.ToString().Trim();
                string query = "select * from Avail_stock where [Quantity]=2 AND [Product Name] like '%" + a + "%'";
                SqlCommand sql = new SqlCommand(query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                avail_stockDataGridView.DataSource = dt;
                conn.Close();
            }
            else
            {
                string query = "select * from Avail_stock where [Quantity]=2";
                SqlCommand sql = new SqlCommand(query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                avail_stockDataGridView.DataSource = dt;
                conn.Close();
            }
            product_NameTextBox.Text = "";
        }

        private void dealer_NameTextBox_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            if (dealer_NameTextBox.Text != null)
            {
                string a = dealer_NameTextBox.Text.ToString().Trim();
                string query = "select * from Avail_stock where [Quantity]=2 AND [Dealer Name] like '%" + a + "%'";
                SqlCommand sql = new SqlCommand(query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                avail_stockDataGridView.DataSource = dt;
                conn.Close();
            }
            else
            {
                string query = "select * from Avail_stock where [Quantity]=2";
                SqlCommand sql = new SqlCommand(query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                avail_stockDataGridView.DataSource = dt;
                conn.Close();
            }
            //dealer_NameTextBox.Text = "";
        }

        private void OrderBook_FormClosing(object sender, FormClosingEventArgs e)
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
