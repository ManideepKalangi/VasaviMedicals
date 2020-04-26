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
    public partial class Admin_ReturnProduct : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\vsms.mdf;Integrated Security=True");
        public Admin_ReturnProduct()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Home h = new Admin_Home();
            h.ShowDialog();
        }

        private void returnDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.returnDetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vsmsDataSet);

        }

        private void Admin_ReturnProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vsmsDataSet.Avail_stock' table. You can move, or remove it, as needed.
            this.avail_stockTableAdapter.Fill(this.vsmsDataSet.Avail_stock);
            // TODO: This line of code loads data into the 'vsmsDataSet.ReturnDetails' table. You can move, or remove it, as needed.
            this.returnDetailsTableAdapter.Fill(this.vsmsDataSet.ReturnDetails);

            
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

            dealer_NameTextBox.Text = "";
            company_NameTextBox.Text = "";
            product_NameTextBox.Text = "";
            batch_NoTextBox.Text = "";
            expiry_DateTextBox.Text = "";
            mRPTextBox.Text = "";
            priceTextBox.Text = "";
            quantityNumericUpDown.Value = 1;
            remarksTextBox.Text = "";
        }

        private void batch_NoTextBox_TextChanged(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            if (batch_NoTextBox.Text != "")
            {
                string a = batch_NoTextBox.Text.ToString().Trim();
                string query = "select * from Avail_stock where [Batch No] like '%" + a + "%'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                avail_stockDataGridView.DataSource = dt;
            }
            else {
                string query = "select * from Avail_stock";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                avail_stockDataGridView.DataSource = dt;
            }
        }

        private void avail_stockDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                dealer_NameTextBox.Text = avail_stockDataGridView.SelectedRows[0].Cells[1].Value.ToString().Trim();
                company_NameTextBox.Text = avail_stockDataGridView.SelectedRows[0].Cells[2].Value.ToString().Trim();
                product_NameTextBox.Text = avail_stockDataGridView.SelectedRows[0].Cells[3].Value.ToString().Trim();
                batch_NoTextBox.Text = avail_stockDataGridView.SelectedRows[0].Cells[4].Value.ToString().Trim();
                expiry_DateTextBox.Text = avail_stockDataGridView.SelectedRows[0].Cells[5].Value.ToString().Trim();
                quantityNumericUpDown.Value = Convert.ToInt32(avail_stockDataGridView.SelectedRows[0].Cells[6].Value);
                mRPTextBox.Text = avail_stockDataGridView.SelectedRows[0].Cells[7].Value.ToString().Trim();
                priceTextBox.Text = avail_stockDataGridView.SelectedRows[0].Cells[9].Value.ToString().Trim();
            }
            catch (Exception) {
                MessageBox.Show("Click on right thing");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            string delname = dealer_NameTextBox.Text.ToString().Trim();
            string comname = company_NameTextBox.Text.ToString().Trim();
            string proname = product_NameTextBox.Text.ToString().Trim();
            string batchno = batch_NoTextBox.Text.ToString().Trim();
            string exp = expiry_DateTextBox.Text.ToString().Trim();
            int quan = Convert.ToInt32(quantityNumericUpDown.Value.ToString());
            decimal m = Convert.ToDecimal(mRPTextBox.Text.ToString());
            DateTime da = return_DateDateTimePicker.Value;
            string remarks = remarksTextBox.Text.ToString().Trim();
            decimal p = Convert.ToDecimal(priceTextBox.Text.ToString());
            decimal totp = quan * p;
            if (delname != "" && comname != "" && proname != "" && batchno != "" && exp != "" && quan != 0 && m != 0 && remarks != "" && p != 0)
            {
                string query = "insert into ReturnDetails ([Dealer Name],[Company Name],[Product Name],[Batch No],[Expiry Date],[Quantity],[MRP],[Return Date],[Price],[Total Price],[Remarks]) " +
                    "values('" + delname + "','" + comname + "','" + proname + "','" + batchno + "','" + exp + "','" + quan + "','" + m + "','" + da + "','" + p + "','" + totp + "','"+remarks+"')";
                SqlCommand sql = new SqlCommand(query, conn);
                string query1 = "update Medicine_details set [Quantity]='"+0+"' where [Batch No]='"+batchno+"' AND [Product Name]='"+proname+"' AND [Dealer Name]='"+delname+"'";
                string query2 = "update Avail_stock set [Quantity]='" + 0 + "' where [Batch No]='" + batchno+"' AND [Product Name]='"+proname+"' AND [Dealer Name]='"+delname+"'";
                SqlCommand sql1 = new SqlCommand(query1, conn);
                SqlCommand sql2 = new SqlCommand(query2, conn);

                int i = sql.ExecuteNonQuery();
                if (i >= 1)
                {
                    sql2.ExecuteNonQuery();
                    sql1.ExecuteNonQuery();
                    MessageBox.Show("Return Details Entered Successfully.....");
                }
                else
                {
                    MessageBox.Show("Return Details Entry Failed.....");
                }
            }
            else {
                MessageBox.Show("Enter all the details.....");
            }
            dealer_NameTextBox.Text = "";
            company_NameTextBox.Text = "";
            product_NameTextBox.Text = "";
            batch_NoTextBox.Text = "";
            expiry_DateTextBox.Text = "";
            mRPTextBox.Text = "";
            priceTextBox.Text = "";
            remarksTextBox.Text = "";
            quantityNumericUpDown.Value = 1;
        }

        private void Admin_ReturnProduct_FormClosing(object sender, FormClosingEventArgs e)
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
