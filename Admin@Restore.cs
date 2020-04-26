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
    public partial class Admin_Restore : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\vsms.mdf;Integrated Security=True");
        public Admin_Restore()
        {
            InitializeComponent();
        }

        private void Admin_Restore_Load(object sender, EventArgs e)
        {
            conn.Close();
            try
            {
                OpenFileDialog sd = new OpenFileDialog();
                sd.Filter = "SQL Server database backup files|*.bak";
                sd.Title = "Database Restore";

                if (sd.ShowDialog() == DialogResult.OK)
                {
                    conn.Open();
                    string sqlstmt1 = "use master;";
                    //string sqlstmt2 = string.Format("Alter Database [" + System.Windows.Forms.Application.StartupPath + "\\vsms.mdf] SET MULTI_USER;");
                    string sqlStmt = string.Format("restore  database [" + System.Windows.Forms.Application.StartupPath + "\\vsms.mdf] from disk='{0}' with Restart", sd.FileName);
                    SqlCommand sql1 = new SqlCommand(sqlstmt1, conn);
                    //SqlCommand sql2 = new SqlCommand(sqlstmt2, conn);
                    sql1.ExecuteNonQuery();
                    //sql2.ExecuteNonQuery();
                    
                    using (SqlCommand bu2 = new SqlCommand(sqlStmt, conn))
                    {
                        
                        bu2.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Database Restored Sucessfully");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Restoration Failed....." + ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Home h = new Admin_Home();
            h.ShowDialog();
        }

        private void Admin_Restore_FormClosing(object sender, FormClosingEventArgs e)
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
