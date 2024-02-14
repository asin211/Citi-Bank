namespace BankingApp
{
    partial class TransferBetweenAccounts
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
            this.fromAccountBalanceLabel = new System.Windows.Forms.Label();
            this.transferMoneyLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.welcomeCustomerLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.showAccountsInfoListBox = new System.Windows.Forms.ListBox();
            this.accountsSelectionLabel = new System.Windows.Forms.Label();
            this.toAccountBalanceLabel = new System.Windows.Forms.Label();
            this.transferButton = new System.Windows.Forms.Button();
            this.transferAmountTextBox = new System.Windows.Forms.TextBox();
            this.transferAmountLabel = new System.Windows.Forms.Label();
            this.comboBoxFromTypesOfAccounts = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxToTypesOfAccounts = new System.Windows.Forms.ComboBox();
            this.accountsDeatilsLabel = new System.Windows.Forms.Label();
            this.manageCustomerButton = new System.Windows.Forms.Button();
            this.accountsOperationsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fromAccountBalanceLabel
            // 
            this.fromAccountBalanceLabel.AutoSize = true;
            this.fromAccountBalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromAccountBalanceLabel.Location = new System.Drawing.Point(53, 322);
            this.fromAccountBalanceLabel.Name = "fromAccountBalanceLabel";
            this.fromAccountBalanceLabel.Size = new System.Drawing.Size(206, 20);
            this.fromAccountBalanceLabel.TabIndex = 31;
            this.fromAccountBalanceLabel.Text = "fromAccountBalanceLabel";
            // 
            // transferMoneyLabel
            // 
            this.transferMoneyLabel.AutoSize = true;
            this.transferMoneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferMoneyLabel.Location = new System.Drawing.Point(32, 166);
            this.transferMoneyLabel.Name = "transferMoneyLabel";
            this.transferMoneyLabel.Size = new System.Drawing.Size(195, 29);
            this.transferMoneyLabel.TabIndex = 30;
            this.transferMoneyLabel.Text = "Transfer Money";
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
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(1020, 20);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(85, 33);
            this.logoutButton.TabIndex = 27;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // showAccountsInfoListBox
            // 
            this.showAccountsInfoListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAccountsInfoListBox.FormattingEnabled = true;
            this.showAccountsInfoListBox.HorizontalScrollbar = true;
            this.showAccountsInfoListBox.ItemHeight = 20;
            this.showAccountsInfoListBox.Location = new System.Drawing.Point(527, 405);
            this.showAccountsInfoListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showAccountsInfoListBox.Name = "showAccountsInfoListBox";
            this.showAccountsInfoListBox.ScrollAlwaysVisible = true;
            this.showAccountsInfoListBox.Size = new System.Drawing.Size(577, 264);
            this.showAccountsInfoListBox.TabIndex = 26;
            // 
            // accountsSelectionLabel
            // 
            this.accountsSelectionLabel.AutoSize = true;
            this.accountsSelectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountsSelectionLabel.Location = new System.Drawing.Point(53, 240);
            this.accountsSelectionLabel.Name = "accountsSelectionLabel";
            this.accountsSelectionLabel.Size = new System.Drawing.Size(118, 20);
            this.accountsSelectionLabel.TabIndex = 25;
            this.accountsSelectionLabel.Text = "From - Account";
            // 
            // toAccountBalanceLabel
            // 
            this.toAccountBalanceLabel.AutoSize = true;
            this.toAccountBalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toAccountBalanceLabel.Location = new System.Drawing.Point(549, 322);
            this.toAccountBalanceLabel.Name = "toAccountBalanceLabel";
            this.toAccountBalanceLabel.Size = new System.Drawing.Size(186, 20);
            this.toAccountBalanceLabel.TabIndex = 24;
            this.toAccountBalanceLabel.Text = "toAccountBalanceLabel";
            // 
            // transferButton
            // 
            this.transferButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferButton.Location = new System.Drawing.Point(59, 510);
            this.transferButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.transferButton.Name = "transferButton";
            this.transferButton.Size = new System.Drawing.Size(143, 46);
            this.transferButton.TabIndex = 21;
            this.transferButton.Text = "Transfer";
            this.transferButton.UseVisualStyleBackColor = true;
            this.transferButton.Click += new System.EventHandler(this.transferButton_Click);
            // 
            // transferAmountTextBox
            // 
            this.transferAmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferAmountTextBox.Location = new System.Drawing.Point(261, 418);
            this.transferAmountTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.transferAmountTextBox.Name = "transferAmountTextBox";
            this.transferAmountTextBox.Size = new System.Drawing.Size(237, 29);
            this.transferAmountTextBox.TabIndex = 20;
            // 
            // transferAmountLabel
            // 
            this.transferAmountLabel.AutoSize = true;
            this.transferAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferAmountLabel.Location = new System.Drawing.Point(53, 420);
            this.transferAmountLabel.Name = "transferAmountLabel";
            this.transferAmountLabel.Size = new System.Drawing.Size(150, 24);
            this.transferAmountLabel.TabIndex = 19;
            this.transferAmountLabel.Text = "Transfer Amount";
            // 
            // comboBoxFromTypesOfAccounts
            // 
            this.comboBoxFromTypesOfAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFromTypesOfAccounts.FormattingEnabled = true;
            this.comboBoxFromTypesOfAccounts.Location = new System.Drawing.Point(48, 276);
            this.comboBoxFromTypesOfAccounts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxFromTypesOfAccounts.Name = "comboBoxFromTypesOfAccounts";
            this.comboBoxFromTypesOfAccounts.Size = new System.Drawing.Size(387, 32);
            this.comboBoxFromTypesOfAccounts.TabIndex = 18;
            this.comboBoxFromTypesOfAccounts.SelectedIndexChanged += new System.EventHandler(this.comboBoxFromTypesOfAccounts_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(549, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "To - Account";
            // 
            // comboBoxToTypesOfAccounts
            // 
            this.comboBoxToTypesOfAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxToTypesOfAccounts.FormattingEnabled = true;
            this.comboBoxToTypesOfAccounts.Location = new System.Drawing.Point(542, 276);
            this.comboBoxToTypesOfAccounts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxToTypesOfAccounts.Name = "comboBoxToTypesOfAccounts";
            this.comboBoxToTypesOfAccounts.Size = new System.Drawing.Size(387, 32);
            this.comboBoxToTypesOfAccounts.TabIndex = 32;
            this.comboBoxToTypesOfAccounts.SelectedIndexChanged += new System.EventHandler(this.comboBoxToTypesOfAccounts_SelectedIndexChanged);
            // 
            // accountsDeatilsLabel
            // 
            this.accountsDeatilsLabel.AutoSize = true;
            this.accountsDeatilsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountsDeatilsLabel.Location = new System.Drawing.Point(565, 374);
            this.accountsDeatilsLabel.Name = "accountsDeatilsLabel";
            this.accountsDeatilsLabel.Size = new System.Drawing.Size(153, 20);
            this.accountsDeatilsLabel.TabIndex = 34;
            this.accountsDeatilsLabel.Text = "Accounts Details";
            // 
            // manageCustomerButton
            // 
            this.manageCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageCustomerButton.Location = new System.Drawing.Point(412, 160);
            this.manageCustomerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manageCustomerButton.Name = "manageCustomerButton";
            this.manageCustomerButton.Size = new System.Drawing.Size(322, 46);
            this.manageCustomerButton.TabIndex = 39;
            this.manageCustomerButton.Text = "Back To Manage Customers";
            this.manageCustomerButton.UseVisualStyleBackColor = true;
            this.manageCustomerButton.Click += new System.EventHandler(this.manageCustomerButton_Click);
            // 
            // accountsOperationsButton
            // 
            this.accountsOperationsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountsOperationsButton.Location = new System.Drawing.Point(756, 160);
            this.accountsOperationsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accountsOperationsButton.MaximumSize = new System.Drawing.Size(322, 46);
            this.accountsOperationsButton.Name = "accountsOperationsButton";
            this.accountsOperationsButton.Size = new System.Drawing.Size(322, 46);
            this.accountsOperationsButton.TabIndex = 40;
            this.accountsOperationsButton.Text = "Accounts Operations";
            this.accountsOperationsButton.UseVisualStyleBackColor = true;
            this.accountsOperationsButton.Click += new System.EventHandler(this.accountsOperationsButton_Click);
            // 
            // TransferBetweenAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1132, 775);
            this.Controls.Add(this.accountsOperationsButton);
            this.Controls.Add(this.manageCustomerButton);
            this.Controls.Add(this.accountsDeatilsLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxToTypesOfAccounts);
            this.Controls.Add(this.fromAccountBalanceLabel);
            this.Controls.Add(this.transferMoneyLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.welcomeCustomerLabel);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.showAccountsInfoListBox);
            this.Controls.Add(this.accountsSelectionLabel);
            this.Controls.Add(this.toAccountBalanceLabel);
            this.Controls.Add(this.transferButton);
            this.Controls.Add(this.transferAmountTextBox);
            this.Controls.Add(this.transferAmountLabel);
            this.Controls.Add(this.comboBoxFromTypesOfAccounts);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TransferBetweenAccounts";
            this.Text = "Transfer Between Accounts";
            this.Load += new System.EventHandler(this.TransferBetweenAccounts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fromAccountBalanceLabel;
        private System.Windows.Forms.Label transferMoneyLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label welcomeCustomerLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.ListBox showAccountsInfoListBox;
        private System.Windows.Forms.Label accountsSelectionLabel;
        private System.Windows.Forms.Label toAccountBalanceLabel;
        private System.Windows.Forms.Button transferButton;
        private System.Windows.Forms.TextBox transferAmountTextBox;
        private System.Windows.Forms.Label transferAmountLabel;
        private System.Windows.Forms.ComboBox comboBoxFromTypesOfAccounts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxToTypesOfAccounts;
        private System.Windows.Forms.Label accountsDeatilsLabel;
        private System.Windows.Forms.Button manageCustomerButton;
        private System.Windows.Forms.Button accountsOperationsButton;
    }
}