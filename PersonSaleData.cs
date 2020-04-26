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
    public partial class PersonSaleData : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\vsms.mdf;Integrated Security=True");

        public PersonSaleData()
        {
            InitializeComponent();
        }
        private void PersonSaleData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vsmsDataSet.Sale_data' table. You can move, or remove it, as needed.
            this.sale_dataTableAdapter1.Fill(this.vsmsDataSet.Sale_data);
            
            string query = "select * from Sale_data";
            SqlCommand sql = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(sql);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sale_dataDataGridView.DataSource = dt;

            phone_NumberTextBox.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.ShowDialog();
        }

        private void PersonSaleData_FormClosing(object sender, FormClosingEventArgs e)
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

        private void phone_NumberTextBox_TextChanged(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            string phone = phone_NumberTextBox.Text.ToString().Trim();
            if (phone != null)
            {
                string query = "select * from Sale_data where ([Phone Number] like '%" + phone + "%')";
                SqlCommand sql = new SqlCommand(query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                sale_dataDataGridView.DataSource = dt;
                phone_NumberTextBox.Text = "";
                conn.Close();
            }
            else
            {
                string query = "select * from Sale_data";
                SqlCommand sql = new SqlCommand(query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                sale_dataDataGridView.DataSource = dt;
                phone_NumberTextBox.Text = "";
                conn.Close();
            }
        }
    }
}
