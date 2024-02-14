using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class AccountsOperations : Form
    {
        Controller controller = new Controller();  // For accessing methods from controller class
        UtilsController utilsController = new UtilsController();

        private Customer customer;

        private Account account; // account for combobox selected account from customer accounts list
        
        public AccountsOperations(Customer customer)
        {
            InitializeComponent();

            // Assign the customer parameter to the private field
            this.customer = customer;
        }

        private void AccountsOperations_Load(object sender, EventArgs e)
        {

            if (customer.Accounts.Count >= 2)
            {
                transferBetweenAccountsButton.Enabled = true;
            }
            else
            {
                transferBetweenAccountsButton.Enabled = false;
            }

            isStaffLabel.Text = string.Empty; //clear any text from the label to display different type of accounts
            customerNameLabel.Text = string.Empty;
            welcomeCustomerLabel.Text = $"Welcome {customer.Name}"; // Welcome Customer Message
            customerNameLabel.Text = $"Name: {customer.Name}";
            isStaffLabel.Text = customer.Staff ? $"Staff: Yes" : $"Staff: No";
            comboBoxTypesOfAccounts.DropDownStyle = ComboBoxStyle.DropDownList;

            this.MaximizeBox = false;
            enterAmountTextBox.MaxLength = 12;

            // Update Customer Account Types
            comboBoxTypesOfAccounts.Items.Clear();  // Clear any items in the combobox
            try
            {
                if (customer.Accounts.Count > 0)
                {
                    // Adding Customer Accounts dynamically in the combebox
                    foreach (var account in customer.Accounts)
                    {
                        comboBoxTypesOfAccounts.Items.Add(account);
                    }
                    comboBoxTypesOfAccounts.SelectedIndex = -1;
                }
            }
            catch (System.IndexOutOfRangeException ex)
            {
                MessageBox.Show($"No accounts found!\nError: {ex.Message}");
            }
        }

        private void comboBoxTypesOfAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            showAccountsInfoListBox.Items.Clear(); // Clearing Listbox Items

            // Selecting specific account from combobox
            if (comboBoxTypesOfAccounts.SelectedItem is Account selectedAccount){
                account = (Account)comboBoxTypesOfAccounts.SelectedItem;
                account.AssociatedCustomer = customer;
                showAccountsInfoListBox.Items.Add(account.AccountInfo());
            }
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            showAccountsInfoListBox.Items.Clear();

            string amount = enterAmountTextBox.Text;
            enterAmountTextBox.Clear(); // Clear the user input

            // Validation if no items are selected from combobox
            if (comboBoxTypesOfAccounts.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid Account!");
            }
            else
            {
                try
                {
                    // deposit validations
                    if (double.TryParse(amount, out double valid_amount) && valid_amount > 0)
                    {
                        if(valid_amount > 10000)
                        {
                            MessageBox.Show("Deposit limit: $10000 per transaction!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            showAccountsInfoListBox.Items.Add(account.AccountInfo());
                            return;
                        }
                        account.Deposit(valid_amount);
                        controller.UpdateCustomer(customer);

                        MessageBox.Show($"${valid_amount} deposited successfully in {account.Type}!");
                        showAccountsInfoListBox.Items.Add(account.AccountInfo());
                    } else
                    {
                        throw new CustomException("Invalid input, please enter amount greater than 0!");
                    }
                }
                catch (CustomException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    showAccountsInfoListBox.Items.Add(account.AccountInfo());
                }
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            showAccountsInfoListBox.Items.Clear();

            string amount = enterAmountTextBox.Text;

            enterAmountTextBox.Clear(); // Clear the user input

            if (comboBoxTypesOfAccounts.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid Account!");
                return;
            }

            try
            {
                if (!double.TryParse(amount, out double valid_amount) || valid_amount <= 0)
                {
                    //Validation if input is not a valid number/double
                    throw new CustomException("Invalid input. Please enter a valid amount greater than 0!");
                } else
                {
                    switch (account.Type)
                    {
                        case "Everyday Account":
                        case "Investment Account":
                        case "Omni Account":
                            if (CheckSufficientBalance(valid_amount))
                            {
                                account.Withdraw(valid_amount);
                                controller.UpdateCustomer(customer);

                                MessageBox.Show($"${valid_amount} withdrawn successfully from {account.Type}!");
                            }
                            else
                            {
                                HandleInsufficientBalance(valid_amount);
                                controller.UpdateCustomer(customer);
                            }
                            break;
                        default:
                            break;
                    }
                    showAccountsInfoListBox.Items.Add(account.AccountInfo());

                }
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                showAccountsInfoListBox.Items.Add(account.AccountInfo());
            }
        }

        private bool CheckSufficientBalance(double amount)
        {
            double balanceThreshold = account.Type == "Omni Account" ? account.Balance + 100 : account.Balance;

            if (balanceThreshold >= amount)
            {
                return true;
            }
            return false;
        }

        private void HandleInsufficientBalance(double amount)
        {
            try
            {
                switch (account.Type)
                {
                    case "Investment Account":
                    case "Omni Account":
                        MessageBox.Show($"Account doesn't have sufficient balance. Failed transaction fee charged ${account.GetFailedTransactionFee()}!");
                        account.ChargeFailedTransactionFee();
                        break;
                    default:
                        MessageBox.Show("Account doesn't have sufficient balance!");
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!");
            }
        }

        private void interestButton_Click(object sender, EventArgs e)
        {
            enterAmountTextBox.Clear();

            showAccountsInfoListBox.Items.Clear();

            try
            {
                if (comboBoxTypesOfAccounts.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a valid Account!");
                }
                else if (account.Type == "Everyday Account")
                {
                    MessageBox.Show("No Interest on this account!");
                    showAccountsInfoListBox.Items.Add(account.AccountInfo());
                }
                else
                {
                    // Interest Validations and Messages
                    double interest_earned = account.CalculateInterest();
                    if (interest_earned > 0)
                    {
                        MessageBox.Show($"Interest amount ${interest_earned} Added Successfully on your balance ${account.Balance}!");
                        account.AddInterest(interest_earned);
                        controller.UpdateCustomer(customer);
                    }
                    else
                    {
                        MessageBox.Show($"No interest earned on ${account.Balance}!");
                    }
                    showAccountsInfoListBox.Items.Add(account.AccountInfo());
                }
                enterAmountTextBox.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!");
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            utilsController.Logout(this);
        }

        private void transferBetweenAccountsButton_Click(object sender, EventArgs e)
        {
            utilsController.NavigateToTransferBetweenAccounts(this, customer);
        }

        private void addAccountButton_Click(object sender, EventArgs e)
        {
            utilsController.NavigateToAddAccounts(this, customer);
        }

        private void manageCustomerButton_Click_1(object sender, EventArgs e)
        {
            utilsController.NavigateToManageCustomers(this);
        }
    }
}