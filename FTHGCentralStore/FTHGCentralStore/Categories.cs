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
    public partial class Categories : UserControl
    {
        private static Categories _instance;
        public Categories()
        {
            InitializeComponent();
            _instance = this;
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            loadCategory();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCategory.cid = 0;
            AddCategory addCategory = new AddCategory();
            addCategory.ShowDialog();
        }

        public static void loadCategory()
        {
            Connection conn = new Connection();
            conn.getData("SELECT id, category_name, description,date_added FROM categories");
            DataTable dt = new DataTable();
            conn.adp.Fill(dt);
            _instance.dgvCategories.DataSource = dt;

        }
        public void searchCategory()
        {
            Connection conn = new Connection();
            conn.getData("SELECT id, category_name, description FROM categories WHERE category_name LIKE '%" + txtSearchCategory.Text + "%'");
            DataTable dt = new DataTable();
           conn.adp.Fill(dt);
            _instance.dgvCategories.DataSource = dt;

        }

        private void dgvCategories_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvCategories.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1);
        }

        private void txtSearchCategory_TextChanged(object sender, EventArgs e)
        {
            searchCategory();
        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                int cid = int.Parse(dgvCategories.Rows[e.RowIndex].Cells[3].Value.ToString());
                AddCategory.cid = cid;
                AddCategory addCat = new AddCategory();
                addCat.ShowDialog();
                
            }
            else if (e.ColumnIndex == 2)
            {
                if (MessageBox.Show("Are you sure you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    int cid = int.Parse(dgvCategories.Rows[e.RowIndex].Cells[3].Value.ToString());
                    Connection conn = new Connection();
                    conn.sendData("DELETE  FROM categories WHERE id = '" + cid + "'");
                    loadCategory();
                    
                }

            }
        }
    }
}
