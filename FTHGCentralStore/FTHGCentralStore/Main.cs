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
    public partial class Main : Form
    {
        private static Main _instance;
        public Main()
        {
            InitializeComponent();
            _instance = this;
        }

        public static void getForm(Control c)
        {
            c.Dock = DockStyle.Fill;
            _instance.panelContainer.Controls.Clear();
            _instance.panelContainer.Controls.Add(c);

        }

        private void showActive(Control btn)
        {
            activePanel.Top = btn.Top;
            activePanel.Height = btn.Height;

        }


        private void btnDashboard_Click(object sender, EventArgs e)
        {
           Dashboard dashboard = new Dashboard();
           getForm(dashboard);
           showActive(btnDashboard);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            getForm(dashboard);
            showActive(btnDashboard);
            if(Login.role == "shop keeper")
            {
                btnShopKeeper.Visible = false;
            }

        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            getForm(orders);
            showActive(btnOrders);
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
             Categories categories = new Categories();
            getForm(categories);
            showActive(btnCategories);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            getForm(products);
            showActive(btnProducts);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            getForm(settings);
            showActive(btnSettings);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Note", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnShopKeeper_Click(object sender, EventArgs e)
        {
            ShopKeepers sk = new ShopKeepers();
            getForm(sk);
            showActive(btnShopKeeper);
        }
    }
}
