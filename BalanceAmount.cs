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
    public partial class BalanceAmount : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\vsms.mdf;Integrated Security=True");
        public BalanceAmount()
        {
            InitializeComponent();
        }

        private void balanceAmountBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.balanceAmountBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vsmsDataSet);

        }

        private void BalanceAmount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vsmsDataSet.BalanceAmount' table. You can move, or remove it, as needed.
            this.balanceAmountTableAdapter.Fill(this.vsmsDataSet.BalanceAmount);

            conn.Close();
            conn.Open();
            SqlCommand sql = new SqlCommand("select [Vendor Name] from VendorDetails", conn);
            SqlDataReader sr = sql.ExecuteReader();
            AutoCompleteStringCollection acsc = new AutoCompleteStringCollection();
            while (sr.Read())
            {
                acsc.Add(sr.GetString(0));
            }
            dealer_NameTextBox.AutoCompleteCustomSource = acsc;
            conn.Close();

            dealer_NameTextBox.Text = "";
            amountTextBox.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            if (dealer_NameTextBox.Text.ToString().Length != 0 && amountTextBox.Text.ToString().Length != 0)
            {
                string delname = dealer_NameTextBox.Text.ToString().Trim();
                decimal amount = Convert.ToDecimal(amountTextBox.Text);
                DateTime datetime = stock_Bill_DateDateTimePicker.Value;
                decimal pb = amount;
                vasavi1.Class1 vc1 = new vasavi1.Class1();
                int x = vc1.NumberValidate(amountTextBox.Text.ToString());
                if (x == 0)
                {
                    string querya = "select count([Vendor Name]) from VendorDetails where [Vendor Name]='" + delname + "'";
                    SqlDataAdapter sdaa = new SqlDataAdapter(querya, conn);
                    DataTable dta = new DataTable();
                    sdaa.Fill(dta);
                    string d = dta.Rows[0][0].ToString();
                    int j = Convert.ToInt32(d);
                    Console.WriteLine(j);
                    if (j >= 1)
                    {
                        string query = "Insert Into BalanceAmount ([Dealer Name],[Stock Bill Date],[Amount],[Pending Balance]) values ('" + delname + "','" + datetime + "','" + amount + "','" + pb + "')";
                        SqlCommand sql = new SqlCommand(query, conn);
                        int i = sql.ExecuteNonQuery();
                        if (i >= 1)
                        {
                            MessageBox.Show("Data Entered successfully.....");
                        }
                        else
                        {
                            MessageBox.Show("Data Entry Failed!!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter Valid DealerName.....");
                    }
                    dealer_NameTextBox.Text = "";
                    amountTextBox.Text = "";

                    string query1 = "select * from BalanceAmount";
                    SqlCommand sql1 = new SqlCommand(query1, conn);
                    SqlDataAdapter sda = new SqlDataAdapter(sql1);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    balanceAmountDataGridView.DataSource = dt;
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Check Amount!!!!");
                }
            }
            else
            {
                MessageBox.Show("Enter all the values!!!");
                dealer_NameTextBox.Text = "";
                amountTextBox.Text = "";
                conn.Close();
            }
        }

        private void BalanceAmount_FormClosing(object sender, FormClosingEventArgs e)
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
