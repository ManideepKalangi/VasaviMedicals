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
    public partial class SaleEntry : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\vsms.mdf;Integrated Security=True");
        int quantity;
        decimal totprice;
        string phone = "0";
        public SaleEntry()
        {
            InitializeComponent();
        }
        private void SaleEntry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vsmsDataSet.Sale_data' table. You can move, or remove it, as needed.
            this.sale_dataTableAdapter1.Fill(this.vsmsDataSet.Sale_data);
            // TODO: This line of code loads data into the 'vsmsDataSet.Avail_stock' table. You can move, or remove it, as needed.
            this.avail_stockTableAdapter1.Fill(this.vsmsDataSet.Avail_stock);
            // TODO: This line of code loads data into the 'vasavimedicalsDataSet.Avail_stock' table. You can move, or remove it, as needed.

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

            string query = "select * from Avail_stock where [Quantity]>=1";
            SqlCommand sql = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(sql);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            avail_stockDataGridView.DataSource = dt;

            customer_NameTextBox.Text = "";
            phone_NumberTextBox.Text = "";
            company_NameTextBox.Text = "";
            product_NameTextBox.Text = "";
            discountTextBox.Text = "";
            priceTextBox.Text = "";
            expiry_DateTextBox.Text = "";
            mRPTextBox.Text = "";
            quantityNumericUpDown.Value = 1;
            batch_NoTextBox.Text = "";

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
            string cusname = customer_NameTextBox.Text.ToString().Trim();
            phone = phone_NumberTextBox.Text.ToString().Trim();
            string comname = company_NameTextBox.Text.ToString().Trim();
            string proname = product_NameTextBox.Text.ToString().Trim();
            string Batchno = batch_NoTextBox.Text.ToString().Trim();
            string Mrp = mRPTextBox.Text.ToString().Trim();
            vasavi1.Class1 vc1 = new vasavi1.Class1();
            if ((Mrp.Length != 0 && Batchno.Length != 0) && (cusname.Length != 0 && phone.Length != 0) && (comname.Length != 0 && proname.Length != 0) && (expiry_DateTextBox.Text.ToString().Length != 0 && discountTextBox.Text.ToString().Length != 0) && priceTextBox.Text.ToString().Length != 0)
            {
                if (expiry_DateTextBox.Text.ToString().Length==4)
                {
                    int x5 = vc1.ExpiryValidate(expiry_DateTextBox.Text.ToString());
                    if (x5 == 0)
                    {
                        int x = vc1.NumberValidate(Mrp);
                        if (x == 0)
                        {
                            int x1 = vc1.NumberValidate(discountTextBox.Text.ToString());
                            if (x1 == 0)
                            {
                                int x2 = vc1.NumberValidate(priceTextBox.Text.ToString());
                                if (x2 == 0)
                                {
                                    decimal M = Convert.ToDecimal(Mrp);
                                    int expdate = Convert.ToInt32(expiry_DateTextBox.Text);
                                    int quan = Convert.ToInt32(quantityNumericUpDown.Value);
                                    DateTime sdate = sale_DateDateTimePicker.Value;
                                    int discount = Convert.ToInt32(discountTextBox.Text);
                                    decimal price = M - M * (discount) / 100;
                                    totprice = price * quan;
                                    int a = phone.Length;
                                    if (a == 10)
                                    {
                                        int x9 = vc1.PhoneValidate(phone);
                                        if (quantity >= quan && quan != 0 && x9 == 0)
                                        {
                                            string query1 = "update Avail_stock set [Quantity]=[Quantity]-'" + quan + "' where ([Expiry Date] like '%" + expdate + "%') AND ([Product Name]='" + proname + "') AND ([Quantity]>=0) AND ([Batch No]='" + Batchno + "')";
                                            SqlCommand sql1 = new SqlCommand(query1, conn);
                                            int j = sql1.ExecuteNonQuery();
                                            if (j >= 1)
                                            {
                                                string query = "insert into Sale_data([Customer Name],[Phone Number],[Company Name],[Product Name],[Batch No],[Expiry Date],[Quantity],[Sale Date],[MRP],[Discount],[Price],[Total Price]) values('" + cusname + "','" + phone + "','" + comname + "','" + proname + "','" + Batchno + "','" + expdate + "','" + quan + "','" + sdate + "','" + M + "','" + discount + "','" + price + "','" + totprice + "')";
                                                SqlCommand sql = new SqlCommand(query, conn);
                                                int i = sql.ExecuteNonQuery();
                                                if (i >= 1)
                                                {
                                                    MessageBox.Show("SaleData Entered Successfully.....");
                                                }
                                                else
                                                {
                                                    MessageBox.Show("SaleData Entry Failed!!!!");
                                                }
                                                customer_NameTextBox.Text = "";
                                                phone_NumberTextBox.Text = "";
                                                company_NameTextBox.Text = "";
                                                product_NameTextBox.Text = "";
                                                discountTextBox.Text = "";
                                                priceTextBox.Text = "";
                                                expiry_DateTextBox.Text = "";
                                                mRPTextBox.Text = "";
                                                quantityNumericUpDown.Value = 1;
                                                batch_NoTextBox.Text = "";
                                                conn.Close();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Error in Product_Name OR Expiry OR Batch_No!!!!");
                                                conn.Close();
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Check Quantity!!!!!");
                                            conn.Close();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Check Phone Number!!!!");
                                        conn.Close();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Check Price!!!!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Check discount!!!!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Check Mrp!!!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Check Expiry Format!!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Check Expiry!!!");
                }
            }
            else
            {
                MessageBox.Show("Enter Missing values!!!!");
            }
            conn.Close();
            conn.Open();
            string query2 = "select * from Avail_stock where [Quantity]>=1";
            SqlCommand sql2 = new SqlCommand(query2, conn);
            SqlDataAdapter sda = new SqlDataAdapter(sql2);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            avail_stockDataGridView.DataSource = dt;
        }

        private void product_NameTextBox_TextChanged(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            String a = product_NameTextBox.Text.ToString().Trim();
            if (a != null)
            {
                String query = "select * from Avail_stock where (([Product Name]) like'%" + a + "%') AND [Quantity]>=1";
                SqlCommand sql = new SqlCommand(query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                avail_stockDataGridView.DataSource = dt;

                conn.Close();
            }
            else
            {
                MessageBox.Show("Enter Correct Product Name!!!!");
                String query = "select * from Avail_stock where [Quantity]>=1";
                SqlCommand sql = new SqlCommand(query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                avail_stockDataGridView.DataSource = dt;

                conn.Close();
            }
        }

        private void avail_stockDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                company_NameTextBox.Text = avail_stockDataGridView.SelectedRows[0].Cells[2].Value.ToString().Trim();
                product_NameTextBox.Text= avail_stockDataGridView.SelectedRows[0].Cells[3].Value.ToString().Trim();
                batch_NoTextBox.Text= avail_stockDataGridView.SelectedRows[0].Cells[4].Value.ToString().Trim();
                expiry_DateTextBox.Text= avail_stockDataGridView.SelectedRows[0].Cells[5].Value.ToString().Trim();
                mRPTextBox.Text= avail_stockDataGridView.SelectedRows[0].Cells[7].Value.ToString().Trim();
                quantity = Convert.ToInt32(avail_stockDataGridView.SelectedRows[0].Cells[6].Value);
                discountTextBox.Text= avail_stockDataGridView.SelectedRows[0].Cells[8].Value.ToString().Trim();
                priceTextBox.Text= avail_stockDataGridView.SelectedRows[0].Cells[10].Value.ToString().Trim();
            }
            catch (Exception)
            {
                MessageBox.Show("Click on Right Thing");
            }
        }

        private void discountTextBox_TextChanged(object sender, EventArgs e)
        {
            if (discountTextBox.Text == "")
            {
                int d = 0;
                string Mrp = mRPTextBox.Text.ToString().Trim();
                decimal m = Convert.ToDecimal(Mrp);
                int quan = Convert.ToInt32(quantityNumericUpDown.Value);
                decimal price = m - m * d / 100;
                priceTextBox.Text = price.ToString();
                totprice = price * quan;

            }
            else {
                int d = Convert.ToInt32(discountTextBox.Text);
                int quan = Convert.ToInt32(quantityNumericUpDown.Value);
                string Mrp = mRPTextBox.Text.ToString().Trim();
                decimal m = Convert.ToDecimal(Mrp);
                decimal price = m - m * d / 100;
                priceTextBox.Text = price.ToString();
                totprice = price * quan;
            }
        }

        private void SaleEntry_FormClosing(object sender, FormClosingEventArgs e)
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
