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
using Microsoft.Reporting.WinForms;

namespace VasaviMedicals
{
    public partial class NewPrintForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\vsms.mdf;Integrated Security=True");
        Orders _orders;
        List<OrderDetails> _list;
        public NewPrintForm(Orders orders,List<OrderDetails> list)
        {
            InitializeComponent();
            _orders = orders;
            _list = list;
        }

        private void NewPrintForm_Load(object sender, EventArgs e)
        {

            try
            {
                
                conn.Close();
                conn.Open();
                vsmsDataSet v = new vsmsDataSet();
                SqlDataAdapter sda = new SqlDataAdapter("select * from PrintTable", conn);
                sda.Fill(v, "PrintTable");
                if (v.Tables["PrintTable"].Rows.Count == 0)
                {
                    MessageBox.Show("No Products Found!!!");
                }
                ReportDataSource rds = new ReportDataSource("DataSet",_list);
                
                ReportParameter[] p = new ReportParameter[]
                {
                    new ReportParameter("InvoiceId",_orders.InvoiceId.ToString()),
                    new ReportParameter("CustomerName",_orders.CustomerName.ToString()),
                    new ReportParameter("CustomerPhone",_orders.PhoneNumber.ToString()),
                    new ReportParameter("OrderDate",_orders.ODate.ToString())
                };
                this.reportViewer.LocalReport.SetParameters(p);
                this.reportViewer.LocalReport.DataSources.Clear();
                this.reportViewer.LocalReport.DataSources.Add(rds);
                this.reportViewer.LocalReport.Refresh();
                this.reportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"Print Error Occoured!!!");
            }
        }
    }
}
