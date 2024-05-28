using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTHGCentralStore
{
    public partial class AddProduct : Form
    {
        public static int pid = 0;
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        private bool m_aeroEnabled;

        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]

        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW; return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        }; DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;
                default: break;
            }
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
        }

        public AddProduct()
        {
            InitializeComponent();
        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            if (pid != 0)
            {
                btnAdd.Text = "Edit Product";
                lblHeader.Text = "Edit Product";
                loadSpecifiedProduct();
            }
            loadCategory();
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

        public void loadSpecifiedProduct()
        {

            Connection conn = new Connection();
            conn.getData("SELECT cid, product_name, quantity FROM products WHERE pid = '" + pid + "'");
            DataTable dt = new DataTable();
            conn.adp.Fill(dt);

            txtProduct.Text = dt.Rows[0][1].ToString();
            txtQuantity.Text = dt.Rows[0][2].ToString();
            //cmbCategories.SelectedValue = int.Parse(dt.Rows[0][0].ToString());


        }
        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (Char.IsDigit(ch))
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add Product")
            {
                if (cmbCategories.SelectedIndex != 0 && txtProduct.Text !="" && txtQuantity.Text != "")
                {
                    Connection conn = new Connection();
                    conn.getData("SELECT * FROM products WHERE product_name ='" + txtProduct.Text + "'");
                    DataTable dt = new DataTable();
                    conn.adp.Fill(dt);

                    if (dt.Rows.Count <= 0)
                    {
                        conn.sendData("INSERT INTO products(cid, quantity, product_name,date_added) VALUES('" + cmbCategories.SelectedValue + "', '" + txtQuantity.Text + "', '" + txtProduct.Text + "','" + DateTime.Now.ToLongDateString() + "')");
                        if (conn.errorText == "")
                        {
                            txtProduct.Text = "";
                            txtQuantity.Text = "";
                            cmbCategories.SelectedIndex = 0;
                            MessageBox.Show("Product added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Products.loadProducts();
                        }
                        else
                        {
                            MessageBox.Show(conn.errorText, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Category already added", "Note", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("All fields are required ", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            if (btnAdd.Text == "Edit Product")
            {
                if (cmbCategories.SelectedIndex != 0 && txtProduct.Text != "" && txtQuantity.Text != "")
                {
                    Connection conn = new Connection();
                    conn.sendData("UPDATE products SET product_name = '" + txtProduct.Text + "', quantity = '" + txtQuantity.Text + "', cid = '" + cmbCategories.SelectedValue.ToString() + "' WHERE pid = '" + pid + "'");

                    if (conn.errorText == "")
                    {
                        MessageBox.Show("Product updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Hide();
                        Products.loadProducts();
                    }
                    else
                    {
                        MessageBox.Show(conn.errorText, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("All fields are required ", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
