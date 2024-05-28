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
    public partial class ShopKeepers : UserControl
    {
        private static ShopKeepers _instance;

        public ShopKeepers()
        {
            InitializeComponent();
            _instance = this;
        }

        private void ShopKeepers_Load(object sender, EventArgs e)
        {
            loadShopKeepers();
        }

        public static void loadShopKeepers()
        {
            Connection conn = new Connection();
            conn.getData("SELECT id, full_name, username FROM users WHERE role = 'shop keeper'");
            DataTable dt = new DataTable();
            conn.adp.Fill(dt);
            _instance.dgvShopKeepers.DataSource = dt;

        }
        public void searchShopKeeper()
        {
            Connection conn = new Connection();
            conn.getData("SELECT id, full_name, username FROM users WHERE role = 'shop keeper' AND full_name LIKE '%" + txtFullName.Text + "%'");
            DataTable dt = new DataTable();
            conn.adp.Fill(dt);
            _instance.dgvShopKeepers.DataSource = dt;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddShopKeeper.id = 0;
            AddShopKeeper addShopKeeper = new AddShopKeeper();
            addShopKeeper.ShowDialog();
        }

        private void dgvShopKeepers_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvShopKeepers.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1);
        }

        private void txtSearchCategory_TextChanged(object sender, EventArgs e)
        {
            searchShopKeeper();
        }

        private void dgvShopKeepers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                int id = int.Parse(dgvShopKeepers.Rows[e.RowIndex].Cells[3].Value.ToString());
                AddShopKeeper.id = id;
                AddShopKeeper addShop = new AddShopKeeper();
                addShop.ShowDialog();

            }
            else if (e.ColumnIndex == 2)
            {
                if (MessageBox.Show("Are you sure you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    int id = int.Parse(dgvShopKeepers.Rows[e.RowIndex].Cells[3].Value.ToString());
                    Connection conn = new Connection();
                    conn.sendData("DELETE  FROM users WHERE id = '" + id + "'");
                    loadShopKeepers();

                }

            }
        }
    }
}
