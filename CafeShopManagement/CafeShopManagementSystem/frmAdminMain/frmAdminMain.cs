using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeShopManagementSystem.frmCashierMainFromforder;

namespace CafeShopManagementSystem.frmAdminMain
{
    public partial class frmAdminMain : Form
    {
        public frmAdminMain()
        {
            InitializeComponent();
        }
        public string LoggedInUsername { get; set; }  // <-- thêm dòng này

        private void close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to Sign out?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Login loginForm = new Login();
                loginForm.Show();

                this.Hide();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

            frmAdminDashboard1.Visible = true;
            frmAdminAddUsers1.Visible = false;
            frmAdminAddProducts1.Visible = false;
            frmCashierCustomers1.Visible = false;

            frmAdminDashboard adhForm = frmAdminDashboard1 as frmAdminDashboard;

            if (adhForm != null)
            {
                adhForm.refreshData();
            }
        }

        private void btnAddCashier_Click(object sender, EventArgs e)
        {
            frmAdminDashboard1.Visible = false;
            frmAdminAddUsers1.Visible = true;
            frmAdminAddProducts1.Visible = false;
            frmCashierCustomers1.Visible = false;

            frmAdminAddUsers acForm = frmAdminAddUsers1 as frmAdminAddUsers;

            if (acForm != null)
            {
                acForm.refreshData();
            }
        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            frmAdminDashboard1.Visible = false;
            frmAdminAddUsers1.Visible = false;
            frmAdminAddProducts1.Visible = true;
            frmCashierCustomers1.Visible = false;

            frmAdminAddProducts aPForm = frmAdminAddProducts1 as frmAdminAddProducts;

            if (aPForm != null)
            {
                aPForm.refreshData();
            }
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            frmAdminDashboard1.Visible = false;
            frmAdminAddUsers1.Visible = false;
            frmAdminAddProducts1.Visible = false;
            frmCashierCustomers1.Visible = true;

            frmCashierCustomers accForm = frmCashierCustomers1 as frmCashierCustomers;

            if (accForm != null)
            {
                accForm.refreshData();
            }
        }
       

        private void frmAdminMain_Load(object sender, EventArgs e)
        {
            lbUsername.Text = LoggedInUsername/*+ LoggedInUsername*/;
        }
    }
}
