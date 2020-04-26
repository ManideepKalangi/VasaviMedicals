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
using System.IO;
using System.Threading;

namespace VasaviMedicals
{
    public partial class Login : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\vsms.mdf;Integrated Security=True");
        public Login()
        {
            InitializeComponent();   
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
            conn.Close();
            // TODO: This line of code loads data into the 'vsmsDataSet.Login_details' table. You can move, or remove it, as needed.
            this.login_detailsTableAdapter1.Fill(this.vsmsDataSet.Login_details);
            
            Unametb.Text = "";
            Passtb.Text = "";
        }
        private void tologin_Click(object sender, EventArgs e)
        {
            if (Unametb.Text.ToString().Trim() == "Mani1225" && Passtb.Text.ToString().Trim() == "Manideep7095@") {
                this.Hide();
                Admin_Home a = new Admin_Home();
                a.ShowDialog();
            }
            else
            {
                conn.Close();
                conn.Open();
                Console.WriteLine("Connection Opened......");
                string query = "select count(*) from Login_details where [Uname] ='" + Unametb.Text.Trim() + "' AND [Upass] = '" + Passtb.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    Console.WriteLine("Logined Successfully......");
                    this.Hide();
                    Home h = new Home();
                    h.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Enter Valid Username & Password");
                }
                Unametb.Text = "";
                Passtb.Text = "";
                conn.Close();
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
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
