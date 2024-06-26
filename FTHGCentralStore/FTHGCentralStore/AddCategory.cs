﻿using System;
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
    public partial class AddCategory : Form
    {
        public static int cid = 0;
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

        public AddCategory()
        {
            InitializeComponent();
        }

        private void AddCategory_Load(object sender, EventArgs e)
        {
            if (cid != 0)
            {
                btnAdd.Text = "Edit Category";
                lblHeader.Text = "Edit Category";
                loadSpecifiedCategory();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add Category")
            {
                if (txtCategory.Text != "" && txtDescription.Text != "")
                {
                    Connection conn = new Connection();
                    conn.getData("SELECT * FROM categories WHERE category_name ='" + txtCategory.Text + "'");
                    DataTable dt = new DataTable();
                    conn.adp.Fill(dt);

                    if (dt.Rows.Count <= 0)
                    {
                        conn.sendData("INSERT INTO categories(category_name,description,date_added) VALUES('" + txtCategory.Text + "', '" + txtDescription.Text + "','" + DateTime.Now.ToLongDateString() + "')");
                        if (conn.errorText == "")
                        {
                            txtCategory.Text = "";
                            txtDescription.Text = "";
                            MessageBox.Show("Category added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Categories.loadCategory();
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

            if (btnAdd.Text == "Edit Category")
            {
                if (txtCategory.Text != "" && txtDescription.Text != "")
                {
                    Connection conn = new Connection();
                    conn.sendData("UPDATE categories SET category_name = '" + txtCategory.Text + "', description = '" + txtDescription.Text + "' WHERE cid = '" + cid + "'");
                    
                    if (conn.errorText == "")
                    {
                        MessageBox.Show("Category Updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public void loadSpecifiedCategory()
        {
            Connection conn = new Connection();
            conn.getData("SELECT cid, category_name, description FROM categories WHERE cid = '" + cid + "'");
            DataTable dt = new DataTable();
            conn.adp.Fill(dt);

            txtCategory.Text = dt.Rows[0][1].ToString();
            txtDescription.Text = dt.Rows[0][2].ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
