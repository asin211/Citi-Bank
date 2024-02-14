namespace BankingApp
{
    partial class AddCustomerAccounts
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
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerAddAccountsDisplayLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.welcomeCustomerLabel = new System.Windows.Forms.Label();
            this.userAccountsList = new System.Windows.Forms.ListBox();
            this.accountsSelectionLabel = new System.Windows.Forms.Label();
            this.isStaffLabel = new System.Windows.Forms.Label();
            this.accountsOperationsButton = new System.Windows.Forms.Button();
            this.transferBetweenAccountsButton = new System.Windows.Forms.Button();
            this.addAccountButton = new System.Windows.Forms.Button();
            this.comboBoxTypesOfAccounts = new System.Windows.Forms.ComboBox();
            this.accountDeatilsLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.manageCustomerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(45, 214);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(164, 20);
            this.customerNameLabel.TabIndex = 31;
            this.customerNameLabel.Text = "customerNameLabel";
            // 
            // customerAddAccountsDisplayLabel
            // 
            this.customerAddAccountsDisplayLabel.AutoSize = true;
            this.customerAddAccountsDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerAddAccountsDisplayLabel.Location = new System.Drawing.Point(35, 160);
            this.customerAddAccountsDisplayLabel.Name = "customerAddAccountsDisplayLabel";
            this.customerAddAccountsDisplayLabel.Size = new System.Drawing.Size(218, 29);
            this.customerAddAccountsDisplayLabel.TabIndex = 30;
            this.customerAddAccountsDisplayLabel.Text = "Add New Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(55, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 46);
            this.label2.TabIndex = 29;
            this.label2.Text = "Citi Bank";
            // 
            // welcomeCustomerLabel
            // 
            this.welcomeCustomerLabel.AutoSize = true;
            this.welcomeCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeCustomerLabel.ForeColor = System.Drawing.Color.SandyBrown;
            this.welcomeCustomerLabel.Location = new System.Drawing.Point(600, 80);
            this.welcomeCustomerLabel.Name = "welcomeCustomerLabel";
            this.welcomeCustomerLabel.Size = new System.Drawing.Size(241, 33);
            this.welcomeCustomerLabel.TabIndex = 28;
            this.welcomeCustomerLabel.Text = "Welcome Admin";
            // 
            // userAccountsList
            // 
            this.userAccountsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userAccountsList.FormattingEnabled = true;
            this.userAccountsList.HorizontalScrollbar = true;
            this.userAccountsList.ItemHeight = 20;
            this.userAccountsList.Location = new System.Drawing.Point(39, 427);
            this.userAccountsList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userAccountsList.Name = "userAccountsList";
            this.userAccountsList.ScrollAlwaysVisible = true;
            this.userAccountsList.Size = new System.Drawing.Size(1059, 324);
            this.userAccountsList.TabIndex = 26;
            // 
            // accountsSelectionLabel
            // 
            this.accountsSelectionLabel.AutoSize = true;
            this.accountsSelectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountsSelectionLabel.Location = new System.Drawing.Point(55, 302);
            this.accountsSelectionLabel.Name = "accountsSelectionLabel";
            this.accountsSelectionLabel.Size = new System.Drawing.Size(101, 20);
            this.accountsSelectionLabel.TabIndex = 25;
            this.accountsSelectionLabel.Text = "Add Account";
            // 
            // isStaffLabel
            // 
            this.isStaffLabel.AutoSize = true;
            this.isStaffLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isStaffLabel.Location = new System.Drawing.Point(45, 252);
            this.isStaffLabel.Name = "isStaffLabel";
            this.isStaffLabel.Size = new System.Drawing.Size(98, 20);
            this.isStaffLabel.TabIndex = 24;
            this.isStaffLabel.Text = "isStaffLabel";
            // 
            // accountsOperationsButton
            // 
            this.accountsOperationsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountsOperationsButton.Location = new System.Drawing.Point(741, 331);
            this.accountsOperationsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accountsOperationsButton.Name = "accountsOperationsButton";
            this.accountsOperationsButton.Size = new System.Drawing.Size(322, 46);
            this.accountsOperationsButton.TabIndex = 23;
            this.accountsOperationsButton.Text = "Accounts Operations";
            this.accountsOperationsButton.UseVisualStyleBackColor = true;
            this.accountsOperationsButton.Click += new System.EventHandler(this.accountsOperationsButton_Click);
            // 
            // transferBetweenAccountsButton
            // 
            this.transferBetweenAccountsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferBetweenAccountsButton.Location = new System.Drawing.Point(741, 252);
            this.transferBetweenAccountsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.transferBetweenAccountsButton.Name = "transferBetweenAccountsButton";
            this.transferBetweenAccountsButton.Size = new System.Drawing.Size(322, 46);
            this.transferBetweenAccountsButton.TabIndex = 22;
            this.transferBetweenAccountsButton.Text = "Transfers Between Accounts";
            this.transferBetweenAccountsButton.UseVisualStyleBackColor = true;
            this.transferBetweenAccountsButton.Click += new System.EventHandler(this.transferBetweenAccountsButton_Click);
            // 
            // addAccountButton
            // 
            this.addAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAccountButton.Location = new System.Drawing.Point(463, 331);
            this.addAccountButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addAccountButton.Name = "addAccountButton";
            this.addAccountButton.Size = new System.Drawing.Size(185, 46);
            this.addAccountButton.TabIndex = 21;
            this.addAccountButton.Text = "Add Account";
            this.addAccountButton.UseVisualStyleBackColor = true;
            this.addAccountButton.Click += new System.EventHandler(this.addAccountButton_Click);
            // 
            // comboBoxTypesOfAccounts
            // 
            this.comboBoxTypesOfAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTypesOfAccounts.FormattingEnabled = true;
            this.comboBoxTypesOfAccounts.Items.AddRange(new object[] {
            "Everyday Account",
            "Investment Account",
            "Omni Account"});
            this.comboBoxTypesOfAccounts.Location = new System.Drawing.Point(49, 338);
            this.comboBoxTypesOfAccounts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxTypesOfAccounts.Name = "comboBoxTypesOfAccounts";
            this.comboBoxTypesOfAccounts.Size = new System.Drawing.Size(387, 32);
            this.comboBoxTypesOfAccounts.TabIndex = 18;
            this.comboBoxTypesOfAccounts.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypesOfAccounts_SelectedIndexChanged);
            // 
            // accountDeatilsLabel
            // 
            this.accountDeatilsLabel.AutoSize = true;
            this.accountDeatilsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountDeatilsLabel.Location = new System.Drawing.Point(45, 396);
            this.accountDeatilsLabel.Name = "accountDeatilsLabel";
            this.accountDeatilsLabel.Size = new System.Drawing.Size(181, 20);
            this.accountDeatilsLabel.TabIndex = 36;
            this.accountDeatilsLabel.Text = "All Accounts Details";
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(1020, 20);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(85, 33);
            this.logoutButton.TabIndex = 27;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // manageCustomerButton
            // 
            this.manageCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageCustomerButton.Location = new System.Drawing.Point(741, 175);
            this.manageCustomerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manageCustomerButton.Name = "manageCustomerButton";
            this.manageCustomerButton.Size = new System.Drawing.Size(322, 46);
            this.manageCustomerButton.TabIndex = 37;
            this.manageCustomerButton.Text = "Back To Manage Customers";
            this.manageCustomerButton.UseVisualStyleBackColor = true;
            this.manageCustomerButton.Click += new System.EventHandler(this.manageCustomerButton_Click);
            // 
            // AddCustomerAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1132, 775);
            this.Controls.Add(this.manageCustomerButton);
            this.Controls.Add(this.accountDeatilsLabel);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.customerAddAccountsDisplayLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.welcomeCustomerLabel);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.userAccountsList);
            this.Controls.Add(this.accountsSelectionLabel);
            this.Controls.Add(this.isStaffLabel);
            this.Controls.Add(this.accountsOperationsButton);
            this.Controls.Add(this.transferBetweenAccountsButton);
            this.Controls.Add(this.addAccountButton);
            this.Controls.Add(this.comboBoxTypesOfAccounts);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddCustomerAccounts";
            this.Text = "Add Customer Account";
            this.Load += new System.EventHandler(this.AddCustomerAccounts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label customerAddAccountsDisplayLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label welcomeCustomerLabel;
        private System.Windows.Forms.ListBox userAccountsList;
        private System.Windows.Forms.Label accountsSelectionLabel;
        private System.Windows.Forms.Label isStaffLabel;
        private System.Windows.Forms.Button accountsOperationsButton;
        private System.Windows.Forms.Button transferBetweenAccountsButton;
        private System.Windows.Forms.Button addAccountButton;
        private System.Windows.Forms.ComboBox comboBoxTypesOfAccounts;
        private System.Windows.Forms.Label accountDeatilsLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button manageCustomerButton;
    }
}