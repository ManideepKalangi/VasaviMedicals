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
    public partial class Admin_VendorDetails : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\vsms.mdf;Integrated Security=True");

        public Admin_VendorDetails()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Home a = new Admin_Home();
            a.ShowDialog();
        }

        private void vendorDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vendorDetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vsmsDataSet);

        }

        private void Admin_VendorDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vsmsDataSet.VendorDetails' table. You can move, or remove it, as needed.
            this.vendorDetailsTableAdapter.Fill(this.vsmsDataSet.VendorDetails);

            string query = "select * from VendorDetails";
            SqlCommand sql = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(sql);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            vendorDetailsDataGridView.DataSource = dt;

            vendor_NameTextBox.Text = "";
            cityTextBox.Text = "";
            phone_NumberTextBox.Text = "";
            gST_NumberTextBox.Text = "";
            pAN_NumberTextBox.Text = "";
            addressTextBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            string vname = vendor_NameTextBox.Text.ToString().Trim();
            string city = cityTextBox.Text.ToString().Trim();
            string phone = phone_NumberTextBox.Text.Trim().ToString();
            string gst = gST_NumberTextBox.Text.ToString().Trim().ToUpper();
            string pan = pAN_NumberTextBox.Text.Trim().ToString().ToUpper();
            string add = addressTextBox.Text.ToString().Trim();
            decimal penb = 0;
            int x, y, z;
            if (vname.Length != 0 && city.Length != 0 && phone.Length != 0 && gst.Length != 0 && pan.Length != 0 && add.Length != 0)
            {
                vasavi1.Class1 vc1 = new vasavi1.Class1();
                x = vc1.PhoneValidate(phone);
                if (x == 0)
                {
                    y = vc1.GstValidation(gst);
                    if (y == 0)
                    {
                        z = vc1.PanValidate(pan);
                        if (z == 0)
                        {
                            string query = "insert into VendorDetails ([Vendor Name],[City],[Phone Number],[GST Number],[PAN Number],[Address],[Pending Balance]) values ('" + vname + "','" + city + "','" + phone + "','" + gst + "','" + pan + "','" + add + "','" + penb + "')";
                            SqlCommand sql = new SqlCommand(query, conn);
                            int i = sql.ExecuteNonQuery();
                            if (i >= 1)
                            {
                                MessageBox.Show("VendorDetails Added Successfully.....");
                                vendor_NameTextBox.Text = "";
                                cityTextBox.Text = "";
                                addressTextBox.Text = "";
                                pAN_NumberTextBox.Text = "";
                                gST_NumberTextBox.Text = "";
                                phone_NumberTextBox.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("VendorDetails Entry Failed!!!");
                                vendor_NameTextBox.Text = "";
                                cityTextBox.Text = "";
                                addressTextBox.Text = "";
                                pAN_NumberTextBox.Text = "";
                                gST_NumberTextBox.Text = "";
                                phone_NumberTextBox.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Enter Valid Pan Number........");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter Valid GST Number.......");
                    }
                }
                else
                {
                    MessageBox.Show("Enter Valid Phone Number.......");
                }
            }
            else 
            {
                MessageBox.Show("Enter Missing Values.....");
            }
            string query1 = "select * from VendorDetails";
            SqlCommand sql1 = new SqlCommand(query1, conn);
            SqlDataAdapter sda = new SqlDataAdapter(sql1);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            vendorDetailsDataGridView.DataSource = dt;
        }

        private void Admin_VendorDetails_FormClosing(object sender, FormClosingEventArgs e)
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
