using BankingApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace BankingApp
{
    public partial class TransferBetweenAccounts : Form
    {
        Controller controller = new Controller();  // For accessing methods from controller class 
        UtilsController utilsController = new UtilsController();

        private Customer customer;

        private Account fromAccount, toAccount;

        public TransferBetweenAccounts(Customer customer)
        {
            // Assign the customer parameter to the private field
            this.customer = customer;

            InitializeComponent();
        }

        private void TransferBetweenAccounts_Load(object sender, EventArgs e)
        {
            welcomeCustomerLabel.Text = $"Welcome {customer.Name}"; // Welcome Customer Message
            this.MaximizeBox = false;

            comboBoxFromTypesOfAccounts.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxToTypesOfAccounts.DropDownStyle = ComboBoxStyle.DropDownList;
            transferAmountTextBox.MaxLength = 12;

            resetFormInputs();
            populateTransferComboBoxes();
            updateAccountsInfoList();
        }

        private void comboBoxFromTypesOfAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customer.Accounts.Count > 0 && comboBoxFromTypesOfAccounts.SelectedItem != null)
            {
                comboBoxToTypesOfAccounts.Items.Clear();
                fromAccount = comboBoxFromTypesOfAccounts.SelectedItem as Account;

                // Add all accounts to the 'To' ComboBox except the selected 'From' account
                foreach (var account in customer.Accounts)
                {
                    if (!account.Equals(fromAccount))
                    {
                        comboBoxToTypesOfAccounts.Items.Add(account);
                    }
                }

                displayBalanceFromAccount(fromAccount);
                comboBoxToTypesOfAccounts.SelectedIndex = -1;
                toAccount = null;
                toAccountBalanceLabel.Text = "";
            }
        }

        private void comboBoxToTypesOfAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customer.Accounts.Count > 0 && comboBoxToTypesOfAccounts.SelectedItem != null)
            {
                toAccount = comboBoxToTypesOfAccounts.SelectedItem as Account;
                if(comboBoxToTypesOfAccounts.SelectedIndex != -1)
                {
                    displayBalanceToAccount(toAccount);
                }
            }
        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            if (fromAccount == null || toAccount == null)
            {
                transferAmountTextBox.Clear();
                // Handle the case where either "From" or "To" account is not selected
                MessageBox.Show("Please select both 'From' and 'To' accounts for the transfer.");
                return;
            }

            if (fromAccount == toAccount)
            {
                transferAmountTextBox.Clear();
                // Handle the case where "From" and "To" accounts are the same
                MessageBox.Show("Please select different 'From' and 'To' accounts for the transfer.");
                return;
            }

            try
            {
                double transferAmount;
                if (double.TryParse(transferAmountTextBox.Text, out transferAmount))
                {
                    if (fromAccount.Balance >= transferAmount)
                    {
                        fromAccount.Withdraw(transferAmount);
                        toAccount.Deposit(transferAmount);
                        controller.UpdateCustomer(customer);
                        MessageBox.Show($"Transfer successful! {transferAmount:C} transferred from {fromAccount.Type} to {toAccount.Type}.");
                        updateAccountsInfoList();
                        resetFormInputs();
                        populateTransferComboBoxes();
                    }
                    else
                    {
                        transferAmountTextBox.Clear();
                        // Handle insufficient funds in the "From" account
                        transferAmountTextBox.Clear();
                        MessageBox.Show("Insufficient funds in the account for the transfer.");
                    }
                }
                else
                {
                    transferAmountTextBox.Clear();
                    // Handle invalid transfer amount input
                    transferAmountTextBox.Clear();
                    MessageBox.Show("Invalid transfer amount. Please enter a valid numeric value.");
                }
            }
            catch (NegativeInputException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void populateTransferComboBoxes()
        {
            comboBoxFromTypesOfAccounts.Items.Clear();
            comboBoxToTypesOfAccounts.Items.Clear();

            if (customer.Accounts.Count > 0)
            {
                foreach (var account in customer.Accounts)
                {
                    comboBoxFromTypesOfAccounts.Items.Add(account);
                }

                foreach (var account in customer.Accounts)
                {
                    comboBoxToTypesOfAccounts.Items.Add(account);
                }
            }
        }

        private void updateAccountsInfoList()
        {

            if (customer.Accounts.Count > 0)
            {
                showAccountsInfoListBox.Items.Clear();
                foreach (var account in customer.Accounts)
                {
                    showAccountsInfoListBox.Items.Add(account.AccountInfo());
                }
            }
        }

        private void resetFormInputs()
        {
            fromAccountBalanceLabel.Text = "";
            toAccountBalanceLabel.Text = "";
            transferAmountTextBox.Clear();

        
            fromAccount = null;
            toAccount = null;

            comboBoxFromTypesOfAccounts.Text = "";
            comboBoxFromTypesOfAccounts.SelectedIndex = -1;

            comboBoxToTypesOfAccounts.Text = "";
            comboBoxToTypesOfAccounts.SelectedIndex = -1;
        }

        private void displayBalanceFromAccount(Account selectedAccount)
        {
            if (selectedAccount != null)
            {
                fromAccountBalanceLabel.Text = $"Current Balance: {selectedAccount.Balance}";
            }
        }

        private void displayBalanceToAccount(Account selectedAccount)
        {
            if (selectedAccount != null)
            {
                toAccountBalanceLabel.Text = $"Current Balance: {selectedAccount.Balance}";
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            utilsController.Logout(this);
        }

        private void accountsOperationsButton_Click(object sender, EventArgs e)
        {
            utilsController.NavigateToAccountsOperations(this, customer);
        }

        private void manageCustomerButton_Click(object sender, EventArgs e)
        {
            utilsController.NavigateToManageCustomers(this);
        }
    }
}





