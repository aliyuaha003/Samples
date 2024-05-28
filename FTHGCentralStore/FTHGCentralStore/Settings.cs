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
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtOld.Text != "" && txtNew.Text != "" && txtConfirm.Text != "")
            {
                Connection conn = new Connection();
                conn.getData("SELECT password FROM users WHERE id =" + Login.userID + "");
                DataTable dt = new DataTable();
                conn.adp.Fill(dt);

                if (txtOld.Text == dt.Rows[0][0].ToString())
                {
                    if (txtNew.Text == txtConfirm.Text)
                    {
                        conn.sendData("UPDATE users SET password = '" + txtNew.Text + "' WHERE id = " + Login.userID + "");
                        MessageBox.Show("Password updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNew.Text = txtOld.Text = txtConfirm.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("New password must match confirm password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Old password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("All fields are required", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
