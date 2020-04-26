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
    public partial class Admin_SaleEntry : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\vsms.mdf;Integrated Security=True");
        int quantity;
        public Admin_SaleEntry()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Home ah = new Admin_Home();
            ah.ShowDialog();
        }

        private void sale_dataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sale_dataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vsmsDataSet);

        }

        private void Admin_SaleEntry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vsmsDataSet.Avail_stock' table. You can move, or remove it, as needed.
            this.avail_stockTableAdapter.Fill(this.vsmsDataSet.Avail_stock);
            // TODO: This line of code loads data into the 'vsmsDataSet.Sale_data' table. You can move, or remove it, as needed.
            this.sale_dataTableAdapter.Fill(this.vsmsDataSet.Sale_data);

            string query = "select * from Sale_data";
            SqlCommand sql = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(sql);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sale_dataDataGridView.DataSource = dt;

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
            idTextBox.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string cusname = customer_NameTextBox.Text.ToString().Trim();
            string phone = phone_NumberTextBox.Text.ToString().Trim();
            string comname = company_NameTextBox.Text.ToString().Trim();
            string proname = product_NameTextBox.Text.ToString().Trim();
            string Batchno = batch_NoTextBox.Text.ToString().Trim();
            string Mrp = mRPTextBox.Text.ToString().Trim();

            if (Mrp != null && Batchno != null && cusname != null && phone != null && comname != null && proname != null && expiry_DateTextBox.Text != "" && discountTextBox.Text != null && priceTextBox.Text != null)
            {
                decimal M = Convert.ToDecimal(Mrp);
                int expdate = Convert.ToInt32(expiry_DateTextBox.Text);
                int quan = Convert.ToInt32(quantityNumericUpDown.Value);
                DateTime sdate = sale_DateDateTimePicker.Value;
                int discount = Convert.ToInt32(discountTextBox.Text);
                decimal price = M - ((M * discount) / 100);
                decimal totprice = price * quan;
                int id = Convert.ToInt32(idTextBox.Text);

                int a = phone.Length;

                if (a == 10 && quan != 0)
                {
                    if (quantity >= quan)
                    {
                        string query1 = "update Avail_stock set [Quantity]=[Quantity]-'" + quan + "' where ([Expiry Date] like '%" + expdate + "%') AND ([Product Name]='" + proname + "') AND ([Quantity]>=0) AND [Batch No]='" + Batchno + "'";
                        SqlCommand sql1 = new SqlCommand(query1, conn);
                        int j = sql1.ExecuteNonQuery();
                        if (j >= 1)
                        {
                            string query = "update Sale_data set [Customer Name] = '" + cusname + "',[Phone Number] = '" + phone + "',[Company Name] = '" + comname + "',[Product Name] = '" + proname + "',[Batch No] = '" + Batchno + "',[Expiry Date] = '" + expdate + "',[Quantity] = '" + quantity + "',[Sale Date]= '" + sdate + "',[MRP] = '" + M + "',[Discount] = '" + discount + "',[Price] = '" + price + "',[Total Price] = '" + totprice + "' where [Id] = '" + id + "'";
                            SqlCommand sql = new SqlCommand(query, conn);
                            int i = sql.ExecuteNonQuery();
                            if (i >= 1)
                            {
                                MessageBox.Show("SaleData Updated Successfully");
                            }
                            else
                            {
                                MessageBox.Show("SaleData Updation Failed!!!!");
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
                            idTextBox.Text = "";

                            conn.Close();
                        }
                        else
                        {
                            MessageBox.Show("Select correct Product Name!!!!");
                            conn.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("You dont have that much quantity!!!!!");
                        conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Enter correct Phone Number or Quantity!!!!");
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Enter all the values!!!!");
                conn.Close();
            }

            string query2 = "select * from Sale_data";
            SqlCommand sql2 = new SqlCommand(query2, conn);
            SqlDataAdapter sda = new SqlDataAdapter(sql2);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sale_dataDataGridView.DataSource = dt;
        }

        private void sale_dataDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                idTextBox.Text = sale_dataDataGridView.SelectedRows[0].Cells[0].Value.ToString().Trim();
                customer_NameTextBox.Text = sale_dataDataGridView.SelectedRows[0].Cells[1].Value.ToString().Trim();
                phone_NumberTextBox.Text = sale_dataDataGridView.SelectedRows[0].Cells[2].Value.ToString().Trim();
                company_NameTextBox.Text = sale_dataDataGridView.SelectedRows[0].Cells[3].Value.ToString().Trim();
                product_NameTextBox.Text = sale_dataDataGridView.SelectedRows[0].Cells[4].Value.ToString().Trim(); ;
                discountTextBox.Text = sale_dataDataGridView.SelectedRows[0].Cells[10].Value.ToString().Trim();
                priceTextBox.Text = sale_dataDataGridView.SelectedRows[0].Cells[11].Value.ToString().Trim(); ;
                expiry_DateTextBox.Text = sale_dataDataGridView.SelectedRows[0].Cells[6].Value.ToString().Trim();
                quantity = Convert.ToInt32(sale_dataDataGridView.SelectedRows[0].Cells[7].Value.ToString().Trim());
                mRPTextBox.Text = sale_dataDataGridView.SelectedRows[0].Cells[9].Value.ToString().Trim();
                batch_NoTextBox.Text = sale_dataDataGridView.SelectedRows[0].Cells[5].Value.ToString().Trim();
                sale_DateDateTimePicker.Text = sale_dataDataGridView.SelectedRows[0].Cells[8].Value.ToString().Trim();
               
            }
            catch (Exception)
            {
                MessageBox.Show("Please clickon Right Thing");
            }
        }

        private void Admin_SaleEntry_FormClosing(object sender, FormClosingEventArgs e)
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
