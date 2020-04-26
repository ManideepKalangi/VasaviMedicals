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
    public partial class StockEntry : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\vsms.mdf;Integrated Security=True");
        decimal pb;
        public StockEntry()
        {
            InitializeComponent();
        }
        private void medicine_detailsDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                company_NameTextBox.Text = medicine_detailsDataGridView.SelectedRows[0].Cells[2].Value.ToString().Trim();
                dealer_NameTextBox.Text = medicine_detailsDataGridView.SelectedRows[0].Cells[1].Value.ToString().Trim();
                product_NameTextBox.Text = medicine_detailsDataGridView.SelectedRows[0].Cells[3].Value.ToString().Trim();
                batch_NoTextBox.Text = medicine_detailsDataGridView.SelectedRows[0].Cells[4].Value.ToString().Trim();
                mRPTextBox.Text = Convert.ToInt32(medicine_detailsDataGridView.SelectedRows[0].Cells[7].Value).ToString();
                expiry_DateTextBox.Text = Convert.ToInt32(medicine_detailsDataGridView.SelectedRows[0].Cells[5].Value).ToString();
                quantityNumericUpDown.Value = Convert.ToInt32(medicine_detailsDataGridView.SelectedRows[0].Cells[6].Value);
                gSTTextBox.Text = Convert.ToInt32(medicine_detailsDataGridView.SelectedRows[0].Cells[9].Value).ToString().Trim();
                discountTextBox.Text = Convert.ToInt32(medicine_detailsDataGridView.SelectedRows[0].Cells[8].Value).ToString().Trim();
                priceTextBox.Text = Convert.ToDecimal(medicine_detailsDataGridView.SelectedRows[0].Cells[10].Value).ToString().Trim();
                pb = Convert.ToDecimal(medicine_detailsDataGridView.SelectedRows[0].Cells[11].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Click on right place!!!!");
            }
        }
        private void StockEntry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vsmsDataSet.Medicine_details' table. You can move, or remove it, as needed.
            this.medicine_detailsTableAdapter1.Fill(this.vsmsDataSet.Medicine_details);
            // TODO: This line of code loads data into the 'vasavimedicalsDataSet.Medicine_details' table. You can move, or remove it, as needed.
            
            string query = "select * from Medicine_details ORDER BY [Id] DESC";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            medicine_detailsDataGridView.DataSource = dt;

            conn.Close();
            conn.Open();
            SqlCommand sql = new SqlCommand("select [Vendor Name] from VendorDetails", conn);
            SqlDataReader sr = sql.ExecuteReader();
            AutoCompleteStringCollection acsc = new AutoCompleteStringCollection();
            while (sr.Read()) {
                acsc.Add(sr.GetString(0));
            }
            dealer_NameTextBox.AutoCompleteCustomSource = acsc;
            conn.Close();
            conn.Open();
            SqlCommand sq = new SqlCommand("select [Product Name] from Avail_stock", conn);
            SqlDataReader sr1 = sq.ExecuteReader();
            AutoCompleteStringCollection acsc1 = new AutoCompleteStringCollection();
            while (sr1.Read())
            {
                acsc1.Add(sr1.GetString(0));
            }
            product_NameTextBox.AutoCompleteCustomSource = acsc1;
            conn.Close();

            company_NameTextBox.Text = "";
            dealer_NameTextBox.Text = "";
            product_NameTextBox.Text = "";
            mRPTextBox.Text = "";
            expiry_DateTextBox.Text = "";
            batch_NoTextBox.Text = "";
            discountTextBox.Text = "";
            gSTTextBox.Text = "";
            quantityNumericUpDown.Value = 1;
            priceTextBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            string cmpname = company_NameTextBox.Text.ToString().Trim();
            string delname = dealer_NameTextBox.Text.ToString();
            string proname = product_NameTextBox.Text.ToString().Trim();
            string exp = expiry_DateTextBox.Text.Trim().ToString();
            string Batchno = batch_NoTextBox.Text.ToString().Trim();
            string pri = priceTextBox.Text.ToString().Trim();
            vasavi1.Class1 vc2 = new vasavi1.Class1();
            if (pri.Length != 0 && cmpname.Length != 0 && delname.Length != 0 && proname.Length != 0 && Batchno.Length != 0 && mRPTextBox.Text.ToString().Length != 0 && exp.Length != 0 && discountTextBox.Text.ToString().Length != 0 && gSTTextBox.Text.ToString().Length != 0)
            {
                int x1 = vc2.NumberValidate(mRPTextBox.Text.ToString());
                if (x1 == 0)
                {
                    int x2 = vc2.NumberValidate(discountTextBox.Text.ToString());
                    if (x2 == 0)
                    {
                        int x3 = vc2.NumberValidate(gSTTextBox.Text.ToString());
                        if (x3 == 0)
                        {
                            int x4 = vc2.NumberValidate(pri);
                            if (x4 == 0)
                            {
                                if (exp.Length == 4)
                                {
                                    int x = vc2.ExpiryValidate(exp);
                                    if (x == 0)
                                    {
                                        decimal M = Convert.ToDecimal(mRPTextBox.Text);
                                        int q = Convert.ToInt32(quantityNumericUpDown.Value);
                                        int Expiry = Int32.Parse(exp);
                                        int discount = Convert.ToInt32(discountTextBox.Text);
                                        decimal price = Convert.ToDecimal(pri);
                                        price = price - ((price * discount) / 100);
                                        int gst = Convert.ToInt32(gSTTextBox.Text);
                                        price = price + ((price * gst) / 100);
                                        decimal totprice = q * price;
                                        pb = pb + totprice;
                                        string query = "insert into Medicine_details([Dealer Name],[Company Name],[Product Name],[Batch No],[Expiry Date],[Quantity],[MRP],[Discount],[GST],[Price],[Total Price]) values('" + delname + "','" + cmpname + "','" + proname + "','" + Batchno + "','" + Expiry + "','" + q + "','" + M + "','" + discount + "','" + gst + "','" + price + "','" + totprice + "')";
                                        SqlCommand sql = new SqlCommand(query, conn);
                                        string querya = "select count([Vendor Name]) from VendorDetails where [Vendor Name]='" + delname + "'";
                                        SqlDataAdapter sdaa = new SqlDataAdapter(querya, conn);
                                        DataTable dta = new DataTable();
                                        sdaa.Fill(dta);
                                        string d = dta.Rows[0][0].ToString();
                                        int j = Convert.ToInt32(d);
                                        Console.WriteLine(j);
                                        if (j >= 1)
                                        {
                                            int i = sql.ExecuteNonQuery();
                                            if (i >= 1)
                                            {
                                                string query1 = "insert into Avail_stock([Dealer Name],[Company Name],[Product Name],[Batch No],[Expiry Date],[Quantity],[MRP],[Discount],[GST],[Price],[Total Price]) values('" + delname + "','" + cmpname + "','" + proname + "','" + Batchno + "','" + Expiry + "','" + q + "','" + M + "','" + discount + "','" + gst + "','" + price + "','" + totprice + "')";
                                                string query3 = "update VendorDetails set [Pending Balance]='" + pb + "' where [Vendor Name]='" + delname + "'";
                                                SqlCommand sql3 = new SqlCommand(query3, conn);
                                                SqlCommand sql1 = new SqlCommand(query1, conn);
                                                sql3.ExecuteNonQuery();
                                                sql1.ExecuteNonQuery();
                                                string query4 = "select [Pending Balance] from VendorDetails where [Vendor Name]='" + delname + "'";
                                                SqlDataAdapter sda1 = new SqlDataAdapter(query4, conn);
                                                DataTable dt1 = new DataTable();
                                                sda1.Fill(dt1);
                                                string h = dt1.Rows[0][0].ToString();
                                                pb = Convert.ToDecimal(h);
                                                pb = pb + totprice;
                                                MessageBox.Show("Data Entered Successfully.....");
                                            }
                                            else
                                            {
                                                MessageBox.Show("Data Entry Failed!!!!1");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Check Dealer Name!!!!!");
                                        }
                                        company_NameTextBox.Text = "";
                                        dealer_NameTextBox.Text = "";
                                        product_NameTextBox.Text = "";
                                        mRPTextBox.Text = "";
                                        expiry_DateTextBox.Text = "";
                                        batch_NoTextBox.Text = "";
                                        discountTextBox.Text = "";
                                        gSTTextBox.Text = "";
                                        quantityNumericUpDown.Value = 1;
                                        priceTextBox.Text = "";
                                    }
                                    else
                                    {
                                        MessageBox.Show("Check Expiry Date Format!!!!");
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Check Expiry Date!!!!!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Check Price!!!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Check Gst!!!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Check Disount!!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Check Mrp!!!!");
                }
            }
            else
            {
                MessageBox.Show("Enter Missing Values!!!!");
            }
            conn.Close();
            conn.Open();
            String query2 = "select * from Medicine_details ORDER BY [Id] DESC";
            SqlCommand sql2 = new SqlCommand(query2, conn);
            SqlDataAdapter sda = new SqlDataAdapter(sql2);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            medicine_detailsDataGridView.DataSource = dt;
            conn.Close();
        }

        private void product_NameTextBox_TextChanged(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            if (product_NameTextBox.Text != null)
            {
                string a = product_NameTextBox.Text.ToString().Trim();
                string query = "select * from Medicine_details where [Product Name] like '%" + a + "%'";
                SqlCommand sql = new SqlCommand(query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                medicine_detailsDataGridView.DataSource = dt;
            }
            else
            {
                string query = "select * from Medicine_details ORDER BY [Id] DESC";
                SqlCommand sql = new SqlCommand(query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                medicine_detailsDataGridView.DataSource = dt;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.ShowDialog();
        }
        private void StockEntry_FormClosing(object sender, FormClosingEventArgs e)
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