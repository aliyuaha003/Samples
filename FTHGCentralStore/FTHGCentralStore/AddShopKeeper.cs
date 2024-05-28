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
    public partial class AddShopKeeper : Form
    {
        public static int id = 0;
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

        public AddShopKeeper()
        {
            InitializeComponent();
        }

        private void AddShopKeeper_Load(object sender, EventArgs e)
        {
            if (id != 0)
            {
                btnAdd.Text = "Edit Shop Keeper";
                lblHeader.Text = "Edit Shop Keeper";
                loadSpecifiedShopKeeper();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add Shop Keeper")
            {
                if (txtFullname.Text != "" && txtUsername.Text != "" && txtPassword.Text != "")
                {
                    Connection conn = new Connection();
                    conn.getData("SELECT * FROM users WHERE username ='" + txtUsername.Text + "'");
                    DataTable dt = new DataTable();
                    conn.adp.Fill(dt);

                    if (dt.Rows.Count <= 0)
                    {
                        conn.sendData("INSERT INTO users(full_name,username,password, role) VALUES('" + txtFullname.Text + "', '" + txtUsername.Text + "','" + txtPassword.Text + "', 'shop keeper')");
                        if (conn.errorText == "")
                        {
                            txtFullname.Text = "";
                            txtUsername.Text = "";
                            txtPassword.Text = "";
                            MessageBox.Show("Shop Keeper added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ShopKeepers.loadShopKeepers();
                        }
                        else
                        {
                            MessageBox.Show(conn.errorText, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Username already exists", "Note", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("All fields are required ", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            if (btnAdd.Text == "Edit Shop Keeper")
            {
                if (txtFullname.Text != "" && txtUsername.Text != "" && txtPassword.Text != "")
                {
                    Connection conn = new Connection();
                    conn.sendData("UPDATE users SET full_name = '" + txtFullname.Text + "', username = '" + txtUsername.Text + "' , password = '" + txtPassword.Text + "' WHERE cid = '" + id + "'");

                    if (conn.errorText == "")
                    {
                        MessageBox.Show("Shop Keeper Updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Hide();
                        Categories.loadCategory();
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
        public void loadSpecifiedShopKeeper()
        {
            Connection conn = new Connection();
            conn.getData("SELECT * FROM users WHERE id = '" + id + "'");
            DataTable dt = new DataTable();
            conn.adp.Fill(dt);

            txtFullname.Text = dt.Rows[0][1].ToString();
            txtUsername.Text = dt.Rows[0][2].ToString();
            txtPassword.Text = dt.Rows[0][3].ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();

        }
    }
    
}
