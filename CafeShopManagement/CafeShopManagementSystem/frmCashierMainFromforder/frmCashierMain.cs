using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeShopManagementSystem.frmAdminMain;

namespace CafeShopManagementSystem.frmCashierMainFromforder
{
    public partial class frmCashierMain : Form
    {

        public string LoggedInUsernamecashier { get; set; }
        public frmCashierMain()
        {
            InitializeComponent();
        } 

      
        private void frmCashierMain_Load(object sender, EventArgs e)
        {
            UserCashier.Text = LoggedInUsernamecashier;
        }

        private void btnDashboardCas_Click_1(object sender, EventArgs e)
        {
            frmAdminDashboard1.Visible = true;
            frmAdminAddProducts1.Visible = false;
            frmCashierOrder1.Visible = false;
            frmCashierCustomers1.Visible = false;

            frmAdminDashboard adhForm = frmAdminDashboard1 as frmAdminDashboard;

            if (adhForm != null)
            {
                adhForm.refreshData();
            }
        }

        private void btnAddProductCas_Click_1(object sender, EventArgs e)
        {
            frmAdminDashboard1.Visible = false;
            frmAdminAddProducts1.Visible = true;
            frmCashierOrder1.Visible = false;
            frmCashierCustomers1.Visible = false;

            frmAdminAddProducts aPForm = frmAdminAddProducts1 as frmAdminAddProducts;

            if (aPForm != null)
            {
                aPForm.refreshData();
            }
        }

        private void btnOrderCas_Click_1(object sender, EventArgs e)
        {
            frmAdminDashboard1.Visible = false;
            frmAdminAddProducts1.Visible = false;
            frmCashierOrder1.Visible = true;
            frmCashierCustomers1.Visible = false;

            frmCashierOrder aCoForm = frmCashierOrder1 as frmCashierOrder;

            if (aCoForm != null)
            {
                aCoForm.refreshData();
            }
        }

        private void btnCustomers_Click_1(object sender, EventArgs e)
        {
            frmAdminDashboard1.Visible = false;
            frmAdminAddProducts1.Visible = false;
            frmCashierOrder1.Visible = false;
            frmCashierCustomers1.Visible = true;

            frmCashierCustomers aCCForm = frmCashierCustomers1 as frmCashierCustomers;

            if (aCCForm != null)
            {
                aCCForm.refreshData();
            }
        }

        private void logout_btn_Cas_Click_1(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to sign out?"
              , "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Login loginForm = new Login();
                loginForm.Show();

                this.Hide();
            }
        }

        private void close_Click_1(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        
    }
}
