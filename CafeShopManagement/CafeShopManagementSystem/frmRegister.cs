﻿using System;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace CafeShopManagementSystem
{
    public partial class frmRegister : Form
    {

        SqlConnection connect = new SqlConnection("Data Source=.;Initial Catalog=CafeShopDB;Integrated Security=True;Encrypt=False");
        public frmRegister()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Register_SignIn_Click(object sender, EventArgs e)
        {
            Login loginfrm = new Login();
            loginfrm.ShowDialog();

            this.Hide();
        }

        private void register_showPass_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showPass.Checked ? '\0':'*';
            register_cPassword.PasswordChar = register_showPass.Checked ? '\0':'*';


        }
        public bool emptyFields()
        {
            if (register_username.Text == "" || register_password.Text == "" || register_cPassword.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btn_register_Signup_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        string selectUsername = "SELECT * FROM users WHERE username = @usern"; // LETS CHECK IF THE USERNAME YOU WANT TO USE IS TAKEN ALREADY

                        using (SqlCommand checkUsername = new SqlCommand(selectUsername, connect))
                        {
                            checkUsername.Parameters.AddWithValue("@usern", register_username.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(checkUsername);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                string usern = register_username.Text.Substring(0, 1).ToUpper() + register_username.Text.Substring(1);
                                MessageBox.Show(usern + " is already taken.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (register_password.Text != register_cPassword.Text)
                            {
                                MessageBox.Show("Password does not match.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (register_password.Text.Length < 8)
                            {
                                MessageBox.Show("Invalid password, at least 8 characters are needed.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO users (username, password, profile_image, role, status, date_reg) " +
                                    "VALUES(@usern, @pass, @image, @role, @status, @date)";
                                DateTime today = DateTime.Today;

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@usern", register_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass", register_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@image", "");
                                    cmd.Parameters.AddWithValue("@role", "Cashier");
                                    cmd.Parameters.AddWithValue("@status", "Approval");
                                    cmd.Parameters.AddWithValue("@date", today);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registered successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // SWITCH FORM INTO LOGIN FORM
                                    Login loginForm = new Login();
                                    loginForm.Show();

                                    this.Hide();
                                }
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
