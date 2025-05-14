namespace CafeShopManagementSystem.frmAdminMain
{
    partial class frmAdminMain
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
            this.close = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnAddProducts = new System.Windows.Forms.Button();
            this.btnAddCashier = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.frmAdminDashboard1 = new CafeShopManagementSystem.frmAdminMain.frmAdminDashboard();
            this.frmAdminAddUsers1 = new CafeShopManagementSystem.frmAdminMain.frmAdminAddUsers();
            this.frmAdminAddProducts1 = new CafeShopManagementSystem.frmAdminMain.frmAdminAddProducts();
            this.frmCashierCustomers1 = new CafeShopManagementSystem.frmCashierMainFromforder.frmCashierCustomers();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 25);
            this.panel1.TabIndex = 0;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(1343, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(20, 20);
            this.close.TabIndex = 26;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cafe Shop Management System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.btnCustomers);
            this.panel2.Controls.Add(this.btnAddProducts);
            this.panel2.Controls.Add(this.btnAddCashier);
            this.panel2.Controls.Add(this.btnDashboard);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lbUsername);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(115, 743);
            this.panel2.TabIndex = 1;
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Location = new System.Drawing.Point(6, 629);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(101, 46);
            this.logout_btn.TabIndex = 25;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.Location = new System.Drawing.Point(7, 416);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(101, 46);
            this.btnCustomers.TabIndex = 24;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnAddProducts
            // 
            this.btnAddProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btnAddProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProducts.ForeColor = System.Drawing.Color.White;
            this.btnAddProducts.Location = new System.Drawing.Point(7, 364);
            this.btnAddProducts.Name = "btnAddProducts";
            this.btnAddProducts.Size = new System.Drawing.Size(101, 46);
            this.btnAddProducts.TabIndex = 23;
            this.btnAddProducts.Text = "Add Products";
            this.btnAddProducts.UseVisualStyleBackColor = false;
            this.btnAddProducts.Click += new System.EventHandler(this.btnAddProducts_Click);
            // 
            // btnAddCashier
            // 
            this.btnAddCashier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btnAddCashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCashier.ForeColor = System.Drawing.Color.White;
            this.btnAddCashier.Location = new System.Drawing.Point(6, 312);
            this.btnAddCashier.Name = "btnAddCashier";
            this.btnAddCashier.Size = new System.Drawing.Size(101, 46);
            this.btnAddCashier.TabIndex = 22;
            this.btnAddCashier.Text = "Add Cashier";
            this.btnAddCashier.UseVisualStyleBackColor = false;
            this.btnAddCashier.Click += new System.EventHandler(this.btnAddCashier_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(6, 260);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(101, 46);
            this.btnDashboard.TabIndex = 21;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CafeShopManagementSystem.Properties.Resources.icons8_Cafe_100px_6;
            this.pictureBox2.Location = new System.Drawing.Point(7, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.Color.White;
            this.lbUsername.Location = new System.Drawing.Point(38, 220);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(45, 16);
            this.lbUsername.TabIndex = 20;
            this.lbUsername.Text = "Admin";
            this.lbUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Admin\'s Portal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Username:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.frmAdminDashboard1);
            this.panel3.Controls.Add(this.frmAdminAddUsers1);
            this.panel3.Controls.Add(this.frmAdminAddProducts1);
            this.panel3.Controls.Add(this.frmCashierCustomers1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(115, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1251, 743);
            this.panel3.TabIndex = 2;
            // 
            // frmAdminDashboard1
            // 
            this.frmAdminDashboard1.Location = new System.Drawing.Point(-1, -1);
            this.frmAdminDashboard1.Name = "frmAdminDashboard1";
            this.frmAdminDashboard1.Size = new System.Drawing.Size(1251, 741);
            this.frmAdminDashboard1.TabIndex = 3;
            // 
            // frmAdminAddUsers1
            // 
            this.frmAdminAddUsers1.Location = new System.Drawing.Point(0, 0);
            this.frmAdminAddUsers1.Name = "frmAdminAddUsers1";
            this.frmAdminAddUsers1.Size = new System.Drawing.Size(1251, 741);
            this.frmAdminAddUsers1.TabIndex = 2;
            // 
            // frmAdminAddProducts1
            // 
            this.frmAdminAddProducts1.Location = new System.Drawing.Point(0, -1);
            this.frmAdminAddProducts1.Name = "frmAdminAddProducts1";
            this.frmAdminAddProducts1.Size = new System.Drawing.Size(1251, 741);
            this.frmAdminAddProducts1.TabIndex = 1;
            // 
            // frmCashierCustomers1
            // 
            this.frmCashierCustomers1.Location = new System.Drawing.Point(0, -1);
            this.frmCashierCustomers1.Name = "frmCashierCustomers1";
            this.frmCashierCustomers1.Size = new System.Drawing.Size(1251, 741);
            this.frmCashierCustomers1.TabIndex = 0;
            // 
            // frmAdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdminMain";
            this.Load += new System.EventHandler(this.frmAdminMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnAddProducts;
        private System.Windows.Forms.Button btnAddCashier;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Panel panel3;
        private frmAdminDashboard frmAdminDashboard1;
        private frmAdminAddUsers frmAdminAddUsers1;
        private frmAdminAddProducts frmAdminAddProducts1;
        private frmCashierMainFromforder.frmCashierCustomers frmCashierCustomers1;
    }
}