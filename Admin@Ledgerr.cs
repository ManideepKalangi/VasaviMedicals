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
    public partial class Admin_Ledgerr : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\vsms.mdf;Integrated Security=True");
        public Admin_Ledgerr()
        {
            InitializeComponent();
        }

        private void vendorDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vendorDetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vsmsDataSet);

        }

        private void Admin_Ledgerr_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vsmsDataSet.BalanceAmount' table. You can move, or remove it, as needed.
            this.balanceAmountTableAdapter.Fill(this.vsmsDataSet.BalanceAmount);
            // TODO: This line of code loads data into the 'vsmsDataSet.INANDOUT' table. You can move, or remove it, as needed.
            this.iNANDOUTTableAdapter.Fill(this.vsmsDataSet.INANDOUT);
            // TODO: This line of code loads data into the 'vsmsDataSet.VendorDetails' table. You can move, or remove it, as needed.
            this.vendorDetailsTableAdapter.Fill(this.vsmsDataSet.VendorDetails);

            conn.Close();
            conn.Open();
            SqlCommand sql = new SqlCommand("select [Vendor Name] from VendorDetails", conn);
            SqlDataReader sr = sql.ExecuteReader();
            AutoCompleteStringCollection acsc = new AutoCompleteStringCollection();
            while (sr.Read())
            {
                acsc.Add(sr.GetString(0));
            }
            vendor_NameTextBox.AutoCompleteCustomSource = acsc;
            conn.Close();

            vendor_NameTextBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Home ah = new Admin_Home();
            ah.ShowDialog();
        }

        private void Admin_Ledgerr_FormClosing(object sender, FormClosingEventArgs e)
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

        private void vendor_NameTextBox_TextChanged(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            String a = vendor_NameTextBox.Text.ToString().Trim();
            if (a != null)
            {
                string q1 = "select * from INANDOUT where [Dealer Name] like '%" + a + "%'";
                SqlDataAdapter sda = new SqlDataAdapter(q1, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                iNANDOUTDataGridView.DataSource = dt;
                string q2 = "select * from BalanceAmount where [Dealer Name] like '%" + a + "%'";
                SqlDataAdapter sda1 = new SqlDataAdapter(q2, conn);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                balanceAmountDataGridView.DataSource = dt1;
            }
            else
            {
                string q1 = "select * from INANDOUT";
                SqlDataAdapter sda = new SqlDataAdapter(q1, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                iNANDOUTDataGridView.DataSource = dt;
                string q2 = "select * from BalanceAmount";
                SqlDataAdapter sda1 = new SqlDataAdapter(q2, conn);
                DataTable dt1 = new DataTable();
                sda.Fill(dt1);
                balanceAmountDataGridView.DataSource = dt1;
            }
            conn.Close();
            conn.Open();
            string query1 = "select sum([Amount]) from INANDOUT where [Dealer Name] like '%" + a + "%'";
            SqlDataAdapter s1 = new SqlDataAdapter(query1, conn);
            DataTable d1 = new DataTable();
            s1.Fill(d1);
            label5.Text = d1.Rows[0][0].ToString();
            string query2 = "select sum([Amount]) from BalanceAmount where [Dealer Name] like '%" + a + "%'";
            SqlDataAdapter s2 = new SqlDataAdapter(query2, conn);
            DataTable d2 = new DataTable();
            s2.Fill(d2);
            label6.Text = d2.Rows[0][0].ToString();
            decimal b = Convert.ToDecimal(d1.Rows[0][0].ToString());
            decimal c = Convert.ToDecimal(d2.Rows[0][0].ToString());
            label8.Text = (c - b).ToString();
            conn.Close();
            vendor_NameTextBox.Text = "";
        }
    }
}
