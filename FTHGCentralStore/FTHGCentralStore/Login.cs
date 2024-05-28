using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTHGCentralStore
{
    public partial class Login : Form
    {
        public static int userID;
        public static string role;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            

            if (txtUsername.Text != "" && txtPassword.Text != "")
            {

                Connection conn = new Connection();
                conn.getData("SELECT * FROM users WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "'");
                DataTable dt = new DataTable();
                conn.adp.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    userID = int.Parse(dt.Rows[0][0].ToString());
                    role = dt.Rows[0][4].ToString();
                    Main main = new Main();
                    main.Show();
                    Hide();

                }
                else
                {
                    MessageBox.Show("Incorrect username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("All fields are required ", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
