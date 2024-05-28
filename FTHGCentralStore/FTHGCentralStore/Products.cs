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
    public partial class Products : UserControl
    {
        private static Products _instance;
        public Products()
        {
            InitializeComponent();
            _instance = this;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddProduct.pid = 0;
            AddProduct addProduct = new AddProduct();
            addProduct.ShowDialog();
        }

        public static void loadProducts()
        {
            Connection conn = new Connection();
            conn.getData("SELECT categories.category_name, products.pid, products.product_name, products.quantity, products.date_added FROM categories INNER JOIN products ON categories.id = products.cid;");
            DataTable dt = new DataTable();
            conn.adp.Fill(dt);
            _instance.dgvProducts.DataSource = dt;

        }

        public void loadSpecifiedProducts()
        {
            Connection conn = new Connection();
            conn.getData("SELECT categories.category_name, products.pid, products.product_name, products.quantity, products.date_added FROM categories INNER JOIN products ON categories.id = products.cid WHERE product_name LIKE '%" + txtSearchProduct.Text+ "%'");
            DataTable dt = new DataTable();
          
            conn.adp.Fill(dt);
            _instance.dgvProducts.DataSource = dt;

        }

        private void Products_Load(object sender, EventArgs e)
        {
            loadProducts();
        }

        private void dgvProducts_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvProducts.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1);
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            loadSpecifiedProducts();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                int pid = int.Parse(dgvProducts.Rows[e.RowIndex].Cells[4].Value.ToString());
                AddProduct.pid = pid;
                AddProduct addProd = new AddProduct();
                addProd.ShowDialog();

            }
            else if (e.ColumnIndex == 2)
            {
                if (MessageBox.Show("Are you sure you want to delete this product?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    int pid = int.Parse(dgvProducts.Rows[e.RowIndex].Cells[4].Value.ToString());
                    Connection conn = new Connection();
                    conn.sendData("DELETE FROM products WHERE pid = '" + pid + "'");
                    loadProducts();

                }

            }
            
        }
    }
}
