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
    public partial class Orders : UserControl
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            loadCategory();
            generateRand();
        }
        public void loadCategory()
        {
            Connection conn = new Connection();
            conn.getData("SELECT id, category_name FROM categories");
            DataTable dt = new DataTable();
            conn.adp.Fill(dt);
            DataRow row = dt.NewRow();
            row[0] = 0;
            row[1] = "Select Category...";
            dt.Rows.InsertAt(row, 0);
            cmbCategories.DataSource = dt;
            cmbCategories.DisplayMember = "category_name";
            cmbCategories.ValueMember = "id";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool foundError = false;
            if (cmbCategories.SelectedIndex != 0 && cmbCategories.SelectedValue != "" && txtQuantity.Text != "")
            {
                foreach (DataGridViewRow row in dgvItems.Rows)
                {
                    if (row.Cells[2].Value.ToString().Contains(cmbProducts.Text.ToString()))
                        foundError = true;
                    else
                        foundError = false;
                }

                if (int.Parse(txtQuantity.Text) <= int.Parse(txtDBQuantity.Text))
                    if (!foundError)
                        dgvItems.Rows.Add("", cmbCategories.Text, cmbProducts.Text.ToString(), txtQuantity.Text,cmbProducts.SelectedValue,txtDBQuantity.Text);
                    else
                        MessageBox.Show("Product already inserted", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Out of stock, avalable is " + txtDBQuantity.Text, "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("All fields are required", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Int32.Parse(cmbCategories.SelectedIndex.ToString()) != 0)
            {
               
                    Connection conn = new Connection();
                    conn.getData("SELECT pid, product_name, quantity FROM products WHERE cid = " + int.Parse(cmbCategories.SelectedValue.ToString()) + "");
                    DataTable dt = new DataTable();
                    conn.adp.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.NewRow();
                        row[0] = 0;
                        row[1] = "Select Product...";
                        dt.Rows.InsertAt(row, 0);
                        cmbProducts.DataSource = dt;
                        cmbProducts.DisplayMember = "product_name";
                        cmbProducts.ValueMember = "pid";
                    }
                    else
                    {
                        cmbProducts.Items.Add("No product...");
                    }

            }
        }

        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProducts.SelectedIndex != 0)
            {
                    Connection conn = new Connection();
                    conn.getData("SELECT quantity FROM products WHERE pid = " + int.Parse(cmbProducts.SelectedValue.ToString()) + "");
                    DataTable dt = new DataTable();
                    conn.adp.Fill(dt);

                    if (dt.Rows.Count > 0)
                        txtDBQuantity.Text = dt.Rows[0][0].ToString();
                    else
                        txtDBQuantity.Text = "";
            }  
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        public void reset() {
            loadCategory();
            txtQuantity.Text = "";
            txtReceiver.Text = "";
            dgvItems.Rows.Clear();
            generateRand();
        }

        private void generateRand()
        {
            Random rand = new Random();
            int randValue = rand.Next(11111111, 99999999);
            lblReceiptID.Text = randValue.ToString();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (dgvItems.Rows.Count > 0)
            {
                if (txtReceiver.Text != "")
                {
                    
                    foreach (DataGridViewRow row in dgvItems.Rows)
                    {
                        Connection conn = new Connection();
                        int quantity = int.Parse(row.Cells[5].Value.ToString()) - int.Parse(row.Cells[3].Value.ToString());
                        conn.sendData("UPDATE products SET quantity = " + quantity + " WHERE pid = " + int.Parse(row.Cells[4].Value.ToString()) + "");
                    }

                    foreach (DataGridViewRow roww in dgvItems.Rows)
                    {
                        Connection conn = new Connection();
                        conn.sendData("INSERT INTO orders(invoiceID,category,product,quantity,receiver,date_added) VALUES(" + int.Parse(lblReceiptID.Text.ToString()) + ", '" + roww.Cells[1].Value.ToString() + "', '" + roww.Cells[2].Value.ToString() + "', " + int.Parse(roww.Cells[3].Value.ToString()) + ",'" + txtReceiver.Text + "','" + txtDate.Text + "')");
                        if (conn.errorText != "") {
                            MessageBox.Show(conn.errorText.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    MessageBox.Show("Your order was successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PrintInvoice.invoiceID = int.Parse(lblReceiptID.Text);
                    PrintInvoice printInvoice = new PrintInvoice();
                    printInvoice.ShowDialog();
                    reset();


                }
                else {
                    MessageBox.Show("Receiver's name required", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Add a product first", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            AllOrders allOrders = new AllOrders();
            Main.getForm(allOrders);
        }

        private void dgvItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // MessageBox.Show(dgvItems.Rows[e.RowIndex].Cells[4].Value.ToString(), "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvItems_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvItems.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1);
        }
    }
}
