using System;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace CafeShopManagementSystem
{
    public partial class Login : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=.;Initial Catalog=CafeShopDB;Integrated Security=True;Encrypt=False");
        public Login()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_register_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.Show();

            this.Hide();
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }

        public bool emptyFields()
        {
            if (login_username.Text == "" || login_password.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        string selectAccount = "SELECT COUNT(*) FROM users WHERE username = @usern AND password = @pass AND status = @status";

                        using (SqlCommand cmd = new SqlCommand(selectAccount, connect))
                        {
                            cmd.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                            cmd.Parameters.AddWithValue("@pass", login_password.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", "Active");

                            int rowCount = (int)cmd.ExecuteScalar();

                            if (rowCount > 0)
                            {
                                string selectRole = "SELECT role FROM users WHERE username = @usern AND password = @pass";

                                using (SqlCommand getRole = new SqlCommand(selectRole, connect))
                                {
                                    getRole.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                                    getRole.Parameters.AddWithValue("@pass", login_password.Text.Trim());

                                    string userRole = getRole.ExecuteScalar() as string;

                                    MessageBox.Show("Login successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    if (userRole == "Admin")
                                    {
                                        
                                        frmAdminMain.frmAdminMain adminForm = new frmAdminMain.frmAdminMain();
                                        adminForm.LoggedInUsername = login_username.Text;
                                        adminForm.Show();

                                        this.Hide();
                                    }
                                    else if (userRole == "Cashier")
                                    {
                                        frmCashierMainFromforder.frmCashierMain cashierMain = new frmCashierMainFromforder.frmCashierMain();
                                        cashierMain.LoggedInUsernamecashier = login_username.Text;
                                        cashierMain.Show();

                                        this.Hide();
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password or there's no Admin's approval.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }

            }
        }
    }
}

