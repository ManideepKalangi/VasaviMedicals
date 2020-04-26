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
    public partial class Admin_StockEntry : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\vsms.mdf;Integrated Security=True");

        public Admin_StockEntry()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Home ah = new Admin_Home();
            ah.ShowDialog();
        }

        private void medicine_detailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.medicine_detailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vsmsDataSet);

        }

        private void Admin_StockEntry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vsmsDataSet.Avail_stock' table. You can move, or remove it, as needed.
            this.avail_stockTableAdapter.Fill(this.vsmsDataSet.Avail_stock);
            // TODO: This line of code loads data into the 'vsmsDataSet.Medicine_details' table. You can move, or remove it, as needed.
            this.medicine_detailsTableAdapter.Fill(this.vsmsDataSet.Medicine_details);


            string query = "select * from Avail_stock";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            avail_stockDataGridView.DataSource = dt;

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
            idTextBox.Text = "";
            priceTextBox.Text = "";
        }
        private void medicine_detailsDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                idTextBox.Text = avail_stockDataGridView.SelectedRows[0].Cells[0].Value.ToString().Trim();
                company_NameTextBox.Text = avail_stockDataGridView.SelectedRows[0].Cells[2].Value.ToString().Trim();
                dealer_NameTextBox.Text = avail_stockDataGridView.SelectedRows[0].Cells[1].Value.ToString().Trim();
                product_NameTextBox.Text = avail_stockDataGridView.SelectedRows[0].Cells[3].Value.ToString().Trim();
                batch_NoTextBox.Text = avail_stockDataGridView.SelectedRows[0].Cells[4].Value.ToString().Trim();
                mRPTextBox.Text = Convert.ToInt32(avail_stockDataGridView.SelectedRows[0].Cells[7].Value).ToString();
                expiry_DateTextBox.Text = Convert.ToInt32(avail_stockDataGridView.SelectedRows[0].Cells[5].Value).ToString();
                quantityNumericUpDown.Value = Convert.ToInt32(avail_stockDataGridView.SelectedRows[0].Cells[6].Value);
                gSTTextBox.Text = Convert.ToInt32(avail_stockDataGridView.SelectedRows[0].Cells[9].Value).ToString().Trim();
                discountTextBox.Text = Convert.ToInt32(avail_stockDataGridView.SelectedRows[0].Cells[8].Value).ToString().Trim();
                priceTextBox.Text = Convert.ToInt32(avail_stockDataGridView.SelectedRows[0].Cells[10].Value).ToString().Trim();
            }
            catch (Exception)
            {
                MessageBox.Show("Click on right place!!!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            string cmpname = company_NameTextBox.Text.ToString().Trim();
            string delname = dealer_NameTextBox.Text.ToString().Trim();
            string proname = product_NameTextBox.Text.ToString().Trim();
            string exp = expiry_DateTextBox.Text.ToString().Trim();
            string Batchno = batch_NoTextBox.Text.ToString().Trim();

            if (cmpname != null && delname != null && proname != null && Batchno != null && mRPTextBox.Text != "" && exp != null && discountTextBox.Text != null && gSTTextBox.Text != "")
            {
                int id = Convert.ToInt32(idTextBox.Text);
                decimal M = Convert.ToDecimal(mRPTextBox.Text);
                int q = Convert.ToInt32(quantityNumericUpDown.Value);
                int Expiry = Int32.Parse(exp);
                int discount = Convert.ToInt32(discountTextBox.Text);
                decimal price = M - ((M * discount) / 100);
                decimal totprice = q * price;
                int gst = Convert.ToInt32(gSTTextBox.Text);
                string query = "update Medicine_details set [Dealer Name] = '" + delname + "',[Company Name] = '" + cmpname + "',[Product Name] = '" + proname + "',[Batch No] = '" + Batchno + "',[Expiry Date] = '" + Expiry + "',[Quantity] = '" + q + "',[MRP] = '" + M + "',[Discount] = '" + discount + "',[GST] = '" + gst + "',[Price] = '" + price + "',[Total Price] = '" + totprice + "' where ([Id] = '"+id+"')";
                string query1 = "update Avail_stock set [Dealer Name] = '" + delname + "',[Company Name] = '" + cmpname + "',[Product Name] = '" + proname + "',[Batch No] = '" + Batchno + "',[Expiry Date] = '" + Expiry + "',[Quantity] = '" + q + "',[MRP] = '" + M + "',[Discount] = '" + discount + "',[GST] = '" + gst + "',[Price] = '" + price + "',[Total Price] = '" + totprice + "' where ([Id] = '" + id + "')";
                SqlCommand sql = new SqlCommand(query, conn);
                SqlCommand sql1 = new SqlCommand(query1, conn);
                sql1.ExecuteNonQuery();
                int i = sql.ExecuteNonQuery();
                if (i >= 1)
                {
                    MessageBox.Show("Data Updated Successfully.....");
                    company_NameTextBox.Text = "";
                    dealer_NameTextBox.Text = "";
                    product_NameTextBox.Text = "";
                    mRPTextBox.Text = "";
                    expiry_DateTextBox.Text = "";
                    batch_NoTextBox.Text = "";
                    discountTextBox.Text = "";
                    gSTTextBox.Text = "";
                    quantityNumericUpDown.Value = 1;
                    idTextBox.Text = "";
                    priceTextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Data Updation Failed!!!!");
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("Enter Missing Values!!!!");
                conn.Close();
            }
            conn.Open();
            String query2 = "select * from Avail_stock";
            SqlCommand sql2 = new SqlCommand(query2, conn);
            SqlDataAdapter sda = new SqlDataAdapter(sql2);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            avail_stockDataGridView.DataSource = dt;
            conn.Close();

        }

        private void Admin_StockEntry_FormClosing(object sender, FormClosingEventArgs e)
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
