using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTHGCentralStore
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            getNewOrders();
            getNewProducts();
            countCategories();
        }

        private void getNewOrders()
        {
            Connection conn = new Connection();
            conn.getData("SELECT DISTINCT invoiceID,receiver,date_added FROM orders ORDER BY date_added DESC");
            DataTable dt = new DataTable();
            conn.adp.Fill(dt);
            lblOrdersCount.Text = dt.Rows.Count.ToString();
            dgvNewOrders.DataSource = dt;
        }


        private void getNewProducts()
        {
            Connection conn = new Connection();
            conn.getData("SELECT DISTINCT categories.category_name, products.product_name, products.quantity FROM categories INNER JOIN products ON categories.id = products.cid");
            DataTable dt = new DataTable();
            conn.adp.Fill(dt);
            lblProductsCount.Text = dt.Rows.Count.ToString();
            dgvNewProducts.DataSource = dt;
        }

        private void countCategories()
        {
            Connection conn = new Connection();
            conn.getData("SELECT * FROM categories");
            DataTable dt = new DataTable();
            conn.adp.Fill(dt);
            lblCategoriesCount.Text = dt.Rows.Count.ToString();
        }
        private void dgvNewOrders_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvNewOrders.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1);
        }

        private void dgvNewProducts_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvNewProducts.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1);
        }
    }
}
