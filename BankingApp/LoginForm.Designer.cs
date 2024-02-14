namespace BankingApp
{
    partial class LoginForm
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
            this.manageCustomersButton = new System.Windows.Forms.Button();
            this.logoLabel = new System.Windows.Forms.Label();
            this.adminLoginLabel = new System.Windows.Forms.Label();
            this.adminPortalLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customerLoginButton = new System.Windows.Forms.Button();
            this.customerLoginSmallLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // manageCustomersButton
            // 
            this.manageCustomersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageCustomersButton.Location = new System.Drawing.Point(138, 334);
            this.manageCustomersButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manageCustomersButton.Name = "manageCustomersButton";
            this.manageCustomersButton.Size = new System.Drawing.Size(286, 69);
            this.manageCustomersButton.TabIndex = 46;
            this.manageCustomersButton.Text = "Admin Login";
            this.manageCustomersButton.UseVisualStyleBackColor = true;
            this.manageCustomersButton.Click += new System.EventHandler(this.manageCustomersButton_Click);
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.logoLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.logoLabel.Location = new System.Drawing.Point(55, 70);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(189, 46);
            this.logoLabel.TabIndex = 43;
            this.logoLabel.Text = "Citi Bank";
            // 
            // adminLoginLabel
            // 
            this.adminLoginLabel.AutoSize = true;
            this.adminLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLoginLabel.Location = new System.Drawing.Point(87, 217);
            this.adminLoginLabel.Name = "adminLoginLabel";
            this.adminLoginLabel.Size = new System.Drawing.Size(292, 31);
            this.adminLoginLabel.TabIndex = 40;
            this.adminLoginLabel.Text = "Welcome to Citi Bank";
            // 
            // adminPortalLabel
            // 
            this.adminPortalLabel.AutoSize = true;
            this.adminPortalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPortalLabel.ForeColor = System.Drawing.Color.SandyBrown;
            this.adminPortalLabel.Location = new System.Drawing.Point(690, 117);
            this.adminPortalLabel.Name = "adminPortalLabel";
            this.adminPortalLabel.Size = new System.Drawing.Size(194, 33);
            this.adminPortalLabel.TabIndex = 36;
            this.adminPortalLabel.Text = "Admin Portal";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BankingApp.Properties.Resources.Designer;
            this.pictureBox1.Location = new System.Drawing.Point(513, 193);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(575, 471);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // customerLoginButton
            // 
            this.customerLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLoginButton.Location = new System.Drawing.Point(138, 454);
            this.customerLoginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customerLoginButton.Name = "customerLoginButton";
            this.customerLoginButton.Size = new System.Drawing.Size(286, 69);
            this.customerLoginButton.TabIndex = 48;
            this.customerLoginButton.Text = "Customer Login";
            this.customerLoginButton.UseVisualStyleBackColor = true;
            this.customerLoginButton.Click += new System.EventHandler(this.customerLoginButton_Click);
            // 
            // customerLoginSmallLabel
            // 
            this.customerLoginSmallLabel.AutoSize = true;
            this.customerLoginSmallLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLoginSmallLabel.Location = new System.Drawing.Point(153, 531);
            this.customerLoginSmallLabel.Name = "customerLoginSmallLabel";
            this.customerLoginSmallLabel.Size = new System.Drawing.Size(191, 16);
            this.customerLoginSmallLabel.TabIndex = 49;
            this.customerLoginSmallLabel.Text = "Customer Login - Coming Soon";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1132, 775);
            this.Controls.Add(this.customerLoginSmallLabel);
            this.Controls.Add(this.customerLoginButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.manageCustomersButton);
            this.Controls.Add(this.logoLabel);
            this.Controls.Add(this.adminLoginLabel);
            this.Controls.Add(this.adminPortalLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.Text = "Citi Bank - Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button manageCustomersButton;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.Label adminLoginLabel;
        private System.Windows.Forms.Label adminPortalLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button customerLoginButton;
        private System.Windows.Forms.Label customerLoginSmallLabel;
    }
}