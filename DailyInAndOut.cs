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
    public partial class DailyInAndOut : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\vsms.mdf;Integrated Security=True");
        decimal pb,pb1;
        public DailyInAndOut()
        {
            InitializeComponent();
        }

        private void DailyInAndOut_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vsmsDataSet.INANDOUT' table. You can move, or remove it, as needed.
            this.iNANDOUTTableAdapter1.Fill(this.vsmsDataSet.INANDOUT);
            

            string query1 = "select * from INANDOUT";
            SqlCommand sql1 = new SqlCommand(query1, conn);
            SqlDataAdapter sda = new SqlDataAdapter(sql1);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            iNANDOUTDataGridView.DataSource = dt;

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

        private void DailyInAndOut_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            if (dealer_NameTextBox.Text != "" && amountTextBox.Text != "")
            {
                string delname = dealer_NameTextBox.Text.ToString().Trim();
                decimal amount = Convert.ToDecimal(amountTextBox.Text);
                DateTime datetime = dateDateTimePicker.Value;
                vasavi1.Class1 vc1 = new vasavi1.Class1();
                int x = vc1.NumberValidate(amountTextBox.Text.ToString());
                if (x == 0)
                {
                    string query2 = "select [Pending Balance] from VendorDetails where [Vendor Name]='" + delname + "'";
                    SqlDataAdapter sda1 = new SqlDataAdapter(query2, conn);
                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);
                    string s = dt1.Rows[0][0].ToString();
                    pb = Convert.ToDecimal(s);
                    pb = pb - amount;


                    string query5 = "select [Pending Balance] from BalanceAmount where [Dealer Name]='" + delname + "'";
                    SqlDataAdapter sda5 = new SqlDataAdapter(query5, conn);
                    DataTable dt5 = new DataTable();
                    sda5.Fill(dt5);
                    string s1 = dt5.Rows[0][0].ToString();
                    pb1 = Convert.ToDecimal(s1);
                    pb1 = pb1 - amount;

                    if (pb > 0 && pb1 > 0)
                    {
                        string query = "Insert Into INANDOUT ([Dealer Name],[Date],[Amount]) values('" + delname + "','" + datetime + "','" + amount + "')";
                        SqlCommand sql = new SqlCommand(query, conn);
                        int i = sql.ExecuteNonQuery();
                        if (i >= 1)
                        {
                            string query3 = "update VendorDetails set [Pending Balance] = '" + pb + "' where [Vendor Name] = '" + delname + "'";
                            string query4 = "update BalanceAmount set [Pending Balance]='" + pb1 + "' where [Dealer Name]='" + delname + "'";
                            SqlCommand sql4 = new SqlCommand(query4, conn);
                            SqlCommand sql2 = new SqlCommand(query3, conn);
                            sql2.ExecuteNonQuery();
                            sql4.ExecuteNonQuery();
                            MessageBox.Show("Data Entered successfully.....");
                            conn.Close();
                        }
                        else
                        {
                            MessageBox.Show("Pending Amount is less than Actual amount......");
                            conn.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Data Entry Failed!!!");
                        conn.Close();
                    }
                    dealer_NameTextBox.Text = "";
                    amountTextBox.Text = "";
                    conn.Open();
                    string query1 = "select * from INANDOUT";
                    SqlCommand sql1 = new SqlCommand(query1, conn);
                    SqlDataAdapter sda = new SqlDataAdapter(sql1);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    iNANDOUTDataGridView.DataSource = dt;
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
            }
            dealer_NameTextBox.Text = "";
            amountTextBox.Text = "";
        }
    }
}
