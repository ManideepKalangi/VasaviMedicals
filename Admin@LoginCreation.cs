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
    public partial class Admin_LoginCreation : Form
    {
        SqlConnection Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\vsms.mdf;Integrated Security=True");
        public Admin_LoginCreation()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Home ah = new Admin_Home();
            ah.ShowDialog();
        }

        private void login_detailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.login_detailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vsmsDataSet);

        }

        private void Admin_LoginCreation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vsmsDataSet.Login_details' table. You can move, or remove it, as needed.
            this.login_detailsTableAdapter.Fill(this.vsmsDataSet.Login_details);

            unameTextBox.Text = "";
            upassTextBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Conn.Open();
            string query = "insert into Login_details([Uname],[Upass]) values('"+unameTextBox.Text.ToString().Trim() + "','"+upassTextBox.Text.ToString().Trim()+"')";
            SqlCommand sql = new SqlCommand(query, Conn);
            int i = sql.ExecuteNonQuery();
            if (i >= 1)
            {
                MessageBox.Show("User with username '"+ unameTextBox.Text.ToString().Trim()+ "' was created......");
            }
            else {
                MessageBox.Show("Creation of user failed!!!!");
            }
            unameTextBox.Text = "";
            upassTextBox.Text = "";
            Conn.Close();
        }

        private void Admin_LoginCreation_FormClosing(object sender, FormClosingEventArgs e)
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
