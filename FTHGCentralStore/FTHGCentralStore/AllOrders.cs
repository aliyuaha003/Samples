using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace FTHGCentralStore
{
    public partial class AllOrders : UserControl
    {
        public AllOrders()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Orders order = new Orders();
            order.Show();
        }

        private void AllOrders_Load(object sender, EventArgs e)
        {
            getOrders();
        }

        private void getOrders()
        {
            Connection conn = new Connection();
            conn.getData("SELECT DISTINCT invoiceID,receiver,date_added FROM orders ORDER BY date_added DESC");
            DataTable dt = new DataTable();
            conn.adp.Fill(dt);
            dgvOrders.DataSource = dt;
        }

        public void loadReceipt(int receiptID)
        {
            Connection conn = new Connection();
            conn.getData("SELECT * FROM orders WHERE invoiceID = " + receiptID + "");
            DataTable dt = new DataTable();
            conn.adp.Fill(dt);
            ReportDataSource rds = new ReportDataSource("CentralStoreDataSet", dt);
            reportViewer1.LocalReport.ReportPath = @"" + conn.path + @"\" + "CentralStoreReport.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        private void dgvOrders_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvOrders.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1);
        }

        private void dgvOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int receiptID = int.Parse(dgvOrders.Rows[e.RowIndex].Cells[2].Value.ToString());
            loadReceipt(receiptID);
        }

        private void txtSearchReceipt_TextChanged(object sender, EventArgs e)
        {
            searchReceipt();
        }
        public void searchReceipt()
        {
            Connection conn = new Connection();
            conn.getData("SELECT DISTINCT invoiceID,receiver,date_added FROM orders WHERE invoiceID LIKE '%" + txtSearchReceipt.Text + "%' ORDER BY date_added DESC");
            DataTable dt = new DataTable();
            conn.adp.Fill(dt);
            dgvOrders.DataSource = dt;

        }
    }
}
