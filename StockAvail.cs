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
    public partial class StockAvail : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\vsms.mdf;Integrated Security=True");

        public StockAvail()
        {
            InitializeComponent();
        }
        private void avail_stockBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.avail_stockBindingSource.EndEdit();
            
        }

        private void StockAvail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vsmsDataSet.Avail_stock' table. You can move, or remove it, as needed.
            this.avail_stockTableAdapter1.Fill(this.vsmsDataSet.Avail_stock);
            conn.Close();
            conn.Open();
            string query = "select * from Avail_stock where [Quantity]>=1";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            avail_stockDataGridView.DataSource = dt;
            conn.Close();
            conn.Open();
            SqlCommand sq = new SqlCommand("select [Product Name] from Avail_stock", conn);
            SqlDataReader sr = sq.ExecuteReader();
            AutoCompleteStringCollection acsc = new AutoCompleteStringCollection();
            while (sr.Read())
            {
                acsc.Add(sr.GetString(0));
            }
            product_NameTextBox.AutoCompleteCustomSource = acsc;
            conn.Close();
            product_NameTextBox.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.ShowDialog();
        }

        private void StockAvail_FormClosing(object sender, FormClosingEventArgs e)
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

        private void product_NameTextBox_TextChanged(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            string a = product_NameTextBox.Text.ToString().Trim();
            if (a != null)
            {
                string query = "select * from Avail_stock where [Product Name] like '%" + a + "%' AND [Quantity]>=1";
                SqlCommand sql = new SqlCommand(query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                avail_stockDataGridView.DataSource = dt;
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
            conn.Close();
        }
    }
}
