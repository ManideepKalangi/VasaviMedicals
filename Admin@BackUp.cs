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
    public partial class Admin_BackUp : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\vsms.mdf;Integrated Security=True");
        public Admin_BackUp()
        {
            InitializeComponent();
        }


        private void Admin_BackUp_Load(object sender, EventArgs e)
        {
            conn.Close();
            try
            {
                SaveFileDialog sd = new SaveFileDialog();
                sd.Filter = "SQL Server database backup files|*.bak";
                sd.Title = "Create Database Backup";

                if (sd.ShowDialog() == DialogResult.OK)
                {
                    string sqlStmt = string.Format("backup database [" + System.Windows.Forms.Application.StartupPath + "\\vsms.mdf] to disk='{0}'", sd.FileName);
                    using (SqlCommand bu2 = new SqlCommand(sqlStmt, conn))
                    {
                        conn.Open();
                        bu2.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Backup Created Sucessfully");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Backup Not Created" + ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Home ah = new Admin_Home();
            ah.ShowDialog(); 
        }

        private void Admin_BackUp_FormClosing(object sender, FormClosingEventArgs e)
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
