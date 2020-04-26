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
    public partial class SalePrint : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\vsms.mdf;Integrated Security=True");
        protected int Invoiceno = 0;
        string cusdetail = "";
        public SalePrint()
        {
            InitializeComponent();
        }

        private void sale_dataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sale_dataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vsmsDataSet);

        }

        private void SalePrint_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vsmsDataSet.PrintTable' table. You can move, or remove it, as needed.
            this.printTableTableAdapter.Fill(this.vsmsDataSet.PrintTable);
            // TODO: This line of code loads data into the 'vsmsDataSet.Sale_data' table. You can move, or remove it, as needed.
            this.sale_dataTableAdapter.Fill(this.vsmsDataSet.Sale_data);
            string query1 = "select * from Sale_data ORDER BY [Sale Date] DESC";
            SqlDataAdapter sda = new SqlDataAdapter(query1, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView2.Rows.Add();
                dataGridView2.Rows[n].Cells[0].Value = false;
                dataGridView2.Rows[n].Cells[1].Value = item[0].ToString();
                dataGridView2.Rows[n].Cells[2].Value = item[1].ToString();
                dataGridView2.Rows[n].Cells[3].Value = item[2].ToString();
                dataGridView2.Rows[n].Cells[4].Value = item[4].ToString();
                dataGridView2.Rows[n].Cells[5].Value = item[7].ToString();
                dataGridView2.Rows[n].Cells[6].Value = item[9].ToString();
                dataGridView2.Rows[n].Cells[7].Value = item[10].ToString();
                dataGridView2.Rows[n].Cells[8].Value = item[12].ToString();
            }
            conn.Close();
            conn.Open();
           
            string q = "select * from PrintTable";
            SqlDataAdapter sda1 = new SqlDataAdapter(q, conn);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            printTableDataGridView.DataSource = dt1;
            conn.Close();
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
            string s1 = "delete from PrintTable";
            SqlCommand sq1 = new SqlCommand(s1, conn);
            sq1.ExecuteNonQuery();
            foreach (DataGridViewRow item in dataGridView2.Rows) {
                if ((bool)item.Cells[0].Value == true) 
                {
                    conn.Close();
                    conn.Open();
                    string cus = item.Cells[2].Value.ToString().Trim();
                    string pro = item.Cells[4].Value.ToString().Trim();
                    string phone = item.Cells[3].Value.ToString().Trim();
                    int quan =Convert.ToInt32(item.Cells[5].Value.ToString().Trim());
                    decimal m=Convert.ToDecimal(item.Cells[6].Value.ToString().Trim());
                    int dis=Convert.ToInt32(item.Cells[7].Value.ToString().Trim());
                    decimal totpri =Convert.ToDecimal(item.Cells[8].Value.ToString().Trim());
                    string query = "Insert Into PrintTable([CustomerName],[PhoneNumber],[ProductName],[Quantity],[MRP],[Discount],[TotalPrice]) Values ('" + cus + "','"+phone+"','" +pro+ "','"+ quan +"','"+ m +"','"+ dis +"','"+ totpri +"')";
                    SqlCommand sql = new SqlCommand(query, conn);
                    sql.ExecuteNonQuery();
                    conn.Close();
                }
            }
            conn.Close();
            conn.Open();
            string q = "select * from PrintTable";
            SqlDataAdapter sda = new SqlDataAdapter(q, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            printTableDataGridView.DataSource=dt;
            conn.Close();
        }

        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            if ((bool)dataGridView2.SelectedRows[0].Cells[0].Value == false)
            {
                dataGridView2.SelectedRows[0].Cells[0].Value = true;
            }
            else {
                dataGridView2.SelectedRows[0].Cells[0].Value = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            Invoiceno++;
            DateTime dt = DateTime.Now;
            Orders obj = new Orders();
            obj.ODate = dt;
            DataTable dy = new DataTable();
            DataTable dy1 = new DataTable();
            try
            {
                string q11 = "select [CustomerName] from PrintTable";
                string q12 = "select [PhoneNumber] from PrintTable";
                SqlDataAdapter sda = new SqlDataAdapter(q11, conn);
                SqlDataAdapter sda1 = new SqlDataAdapter(q12, conn);
                sda1.Fill(dy1);
                sda.Fill(dy);
                obj.CustomerName = dy.Rows[0][0].ToString();
                obj.PhoneNumber = dy1.Rows[0][0].ToString();
                cusdetail = dy.Rows[0][0].ToString() + " ," + dy1.Rows[0][0].ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Error in Customer Name & Number!!!");

            }
            List<OrderDetails> list = new List<OrderDetails>();
            list.Clear();
            conn.Close();
            conn.Open();
            string q1 = "select * from PrintTable";
            string saledata = "";
            decimal TotalAmount = 0;
            SqlCommand sql = new SqlCommand(q1, conn);
            SqlDataReader reader = sql.ExecuteReader();
            while (reader.Read()) {
                OrderDetails o = new OrderDetails();
                o.CustomerName = (string)reader["CustomerName"];
                o.Phone = (string)reader["PhoneNumber"];
                o.ProductName = (string)reader["ProductName"];
                o.Quantity = (int)reader["Quantity"];
                o.MRP = (decimal)reader["MRP"];
                o.Discount = (int)reader["Discount"];
                saledata =saledata+","+ (string)reader["ProductName"] + "," + (int)reader["Quantity"] + "," + (decimal)reader["MRP"]+ "," + (int)reader["Discount"]+"//";
                TotalAmount = TotalAmount+((int)reader["Quantity"] * (decimal)reader["MRP"] - ((int)reader["Quantity"] * (int)reader["Discount"] * (decimal)reader["MRP"])/100);
                list.Add(o);
            }
            conn.Close();
            conn.Open();
            DateTime printdate = dt;
            string qw = "Insert Into TableSale([CustDetails],[SaleData],[PrintDate],[TotalAmount]) Values ('" + cusdetail + "','" + saledata + "','" + printdate + "','" + TotalAmount + "')";
            SqlCommand sq = new SqlCommand(qw, conn);
            sq.ExecuteNonQuery();
            string asd = "select count([CustDetails]) from TableSale";
            SqlDataAdapter sd = new SqlDataAdapter(asd, conn);
            DataTable dt2 = new DataTable();
            sd.Fill(dt2);
            obj.InvoiceId = (int)dt2.Rows[0][0];
            NewPrintForm pf = new NewPrintForm(obj,list);
            pf.ShowDialog();
            conn.Close();
            conn.Open();
            string q = "select * from PrintTable";
            SqlDataAdapter sda11 = new SqlDataAdapter(q, conn);
            DataTable dt1 = new DataTable();
            sda11.Fill(dt1);
            printTableDataGridView.DataSource = dt1;
            conn.Close();
        }

        private void SalePrint_FormClosing(object sender, FormClosingEventArgs e)
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
