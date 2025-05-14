namespace CafeShopManagementSystem
{
    partial class frmRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Register_SignIn = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Label();
            this.register_username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_register_Signup = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.register_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.register_cPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.register_showPass = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_Register_SignIn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 475);
            this.panel1.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Thistle;
            this.label6.Location = new System.Drawing.Point(12, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(307, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cafe Shop Management System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CafeShopManagementSystem.Properties.Resources.icons8_Cafe_100px_6;
            this.pictureBox1.Location = new System.Drawing.Point(105, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Thistle;
            this.label5.Location = new System.Drawing.Point(55, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Already have an account?";
            // 
            // btn_Register_SignIn
            // 
            this.btn_Register_SignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btn_Register_SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Register_SignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register_SignIn.ForeColor = System.Drawing.Color.White;
            this.btn_Register_SignIn.Location = new System.Drawing.Point(25, 389);
            this.btn_Register_SignIn.Name = "btn_Register_SignIn";
            this.btn_Register_SignIn.Size = new System.Drawing.Size(270, 37);
            this.btn_Register_SignIn.TabIndex = 13;
            this.btn_Register_SignIn.Text = "SIGN IN";
            this.btn_Register_SignIn.UseVisualStyleBackColor = false;
            this.btn_Register_SignIn.Click += new System.EventHandler(this.btn_Register_SignIn_Click);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(613, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(20, 20);
            this.close.TabIndex = 25;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // register_username
            // 
            this.register_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_username.Location = new System.Drawing.Point(357, 145);
            this.register_username.Name = "register_username";
            this.register_username.Size = new System.Drawing.Size(275, 26);
            this.register_username.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(355, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Password:";
            // 
            // btn_register_Signup
            // 
            this.btn_register_Signup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btn_register_Signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register_Signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register_Signup.ForeColor = System.Drawing.Color.White;
            this.btn_register_Signup.Location = new System.Drawing.Point(358, 358);
            this.btn_register_Signup.Name = "btn_register_Signup";
            this.btn_register_Signup.Size = new System.Drawing.Size(115, 37);
            this.btn_register_Signup.TabIndex = 24;
            this.btn_register_Signup.Text = "SIGNUP";
            this.btn_register_Signup.UseVisualStyleBackColor = false;
            this.btn_register_Signup.Click += new System.EventHandler(this.btn_register_Signup_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(354, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Username:";
            // 
            // register_password
            // 
            this.register_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_password.Location = new System.Drawing.Point(358, 206);
            this.register_password.Name = "register_password";
            this.register_password.PasswordChar = '*';
            this.register_password.Size = new System.Drawing.Size(275, 26);
            this.register_password.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "REGISTER";
            // 
            // register_cPassword
            // 
            this.register_cPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_cPassword.Location = new System.Drawing.Point(358, 271);
            this.register_cPassword.Name = "register_cPassword";
            this.register_cPassword.PasswordChar = '*';
            this.register_cPassword.Size = new System.Drawing.Size(275, 26);
            this.register_cPassword.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(355, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 18);
            this.label7.TabIndex = 27;
            this.label7.Text = "Confirm Password:";
            // 
            // register_showPass
            // 
            this.register_showPass.AutoSize = true;
            this.register_showPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_showPass.Location = new System.Drawing.Point(358, 303);
            this.register_showPass.Name = "register_showPass";
            this.register_showPass.Size = new System.Drawing.Size(136, 22);
            this.register_showPass.TabIndex = 26;
            this.register_showPass.Text = "Show Password";
            this.register_showPass.UseVisualStyleBackColor = true;
            this.register_showPass.CheckedChanged += new System.EventHandler(this.register_showPass_CheckedChanged);
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 475);
            this.Controls.Add(this.register_cPassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.register_showPass);
            this.Controls.Add(this.btn_register_Signup);
            this.Controls.Add(this.register_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.register_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegister";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Register_SignIn;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.TextBox register_username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_register_Signup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox register_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox register_cPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox register_showPass;
    }
}