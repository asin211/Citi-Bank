using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class AddCustomerAccounts : Form
    {
        Controller controller = new Controller();
        UtilsController utilsController = new UtilsController();

        private Customer customer;

        public AddCustomerAccounts(Customer customer)
        {
            InitializeComponent();

            // Assign the customer parameter to the private field
            this.customer = customer;
        }

        private void AddCustomerAccounts_Load(object sender, EventArgs e)
        {

            if (customer != null)
            {
                welcomeCustomerLabel.Text = $"Welcome {customer.Name}";
                customerNameLabel.Text = $"Name: {customer.Name}";
                isStaffLabel.Text = $"Staff: {(customer.Staff ? "Yes" : "No")}";
                comboBoxTypesOfAccounts.DropDownStyle = ComboBoxStyle.DropDownList;
                this.MaximizeBox = false;

                enablDisableButtons();
                updateAccountsList();
            }
        }

        private void updateAccountsList()
        {
            userAccountsList.Items.Clear();

            // Display loaded data from saved file
            if (customer.Accounts.Count <= 0)
            {
                userAccountsList.Items.Add("No Accounts to display!");
            }
            else
            {
                foreach (var account in customer.Accounts)
                {
                    userAccountsList.Items.Add(account.AccountInfo());
                }
            }

            comboBoxTypesOfAccounts.SelectedIndex = -1;
            enablDisableButtons();
        }

        private void addAccountButton_Click(object sender, EventArgs e)
        {
            //  update id from  serialised data
            int nextId;

            if(comboBoxTypesOfAccounts.SelectedItem.ToString() == "Everyday Account")
            {
                if(customer.Accounts.Count > 0)
                {
                    nextId = customer.Accounts.Max(account => account.AccountId) + 1;
                    EverydayAccount everydayAccount = new EverydayAccount(nextId, 0);
                    customer.AddAccount(everydayAccount);
                }
                else
                {
                    EverydayAccount everydayAccount = new EverydayAccount(0);
                    customer.AddAccount(everydayAccount);
                }
            }
            else if(comboBoxTypesOfAccounts.SelectedItem.ToString() == "Investment Account")
            {
                if (customer.Accounts.Count > 0)
                {
                    nextId = customer.Accounts.Max(account => account.AccountId) + 1;
                    InvestmentAccount investmentAccount = new InvestmentAccount(nextId, 0);
                    customer.AddAccount(investmentAccount);
                }
                else
                {
                    InvestmentAccount investmentAccount = new InvestmentAccount(0);
                    customer.AddAccount(investmentAccount);
                }
            }
            else if(comboBoxTypesOfAccounts.SelectedItem.ToString() == "Omni Account")
            {
                if (customer.Accounts.Count > 0)
                {
                    nextId = customer.Accounts.Max(account => account.AccountId) + 1;
                    //  update id from  serialised data
                    OmniAccount omniAccount = new OmniAccount(nextId, 0);
                    customer.AddAccount(omniAccount);
                }
                else
                {
                    OmniAccount omniAccount = new OmniAccount(0);
                    customer.AddAccount(omniAccount);
                }
            }
            controller.UpdateCustomer(customer); // Updating customer data
            updateAccountsList();
            MessageBox.Show("Account added successfully!");
        }

        private void comboBoxTypesOfAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            enablDisableButtons();
        }

        private void enablDisableButtons()
        {
            if (comboBoxTypesOfAccounts.SelectedIndex != -1)
            {
                addAccountButton.Enabled = true;
            }
            else
            {
                addAccountButton.Enabled = false;
            }
            if(customer.Accounts.Count >= 2)
            {
                transferBetweenAccountsButton.Enabled = true;
            }
            else
            {
                transferBetweenAccountsButton.Enabled = false;
            }
            
            if(customer.Accounts.Count >= 1)
            {
                accountsOperationsButton.Enabled = true;
            }
            else
            {
                accountsOperationsButton.Enabled = false;
            }
        }

        private void transferBetweenAccountsButton_Click(object sender, EventArgs e)
        {
            utilsController.NavigateToTransferBetweenAccounts(this, customer);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            utilsController.Logout(this);
        }

        private void manageCustomerButton_Click(object sender, EventArgs e)
        {
            utilsController.NavigateToManageCustomers(this);
        }

        private void accountsOperationsButton_Click(object sender, EventArgs e)
        {
            utilsController.NavigateToAccountsOperations(this, customer);
        }
    }
}