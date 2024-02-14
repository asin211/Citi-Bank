using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    internal class UtilsController
    {
        public void Logout(Form currentForm)
        {
            currentForm.Hide();

            LoginForm loginForm = new LoginForm();

            // Show the newForm and close the current form
            loginForm.FormClosed += (s, args) => currentForm.Close();
            loginForm.Show();
        }

        public void NavigateToManageCustomers(Form currentForm)
        {
            currentForm.Hide();

            ManageCustomers manageCustomersForm = new ManageCustomers();

            // Show the newForm and close the current form
            manageCustomersForm.FormClosed += (s, args) => currentForm.Close();
            manageCustomersForm.Show();
        }

        public void NavigateToAddAccounts(Form currentForm, Customer customer)
        {
            currentForm.Hide();

            AddCustomerAccounts addCustomerAccountsForm = new AddCustomerAccounts(customer);

            // Show the newForm and close the current form
            addCustomerAccountsForm.FormClosed += (s, args) => currentForm.Close();
            addCustomerAccountsForm.Show();
        }

        public void NavigateToAccountsOperations(Form currentForm, Customer customer)
        {
            currentForm.Hide();

            AccountsOperations accountsOperationsForm = new AccountsOperations(customer);

            // Show the newForm and close the current form
            accountsOperationsForm.FormClosed += (s, args) => currentForm.Close();
            accountsOperationsForm.Show();
        }

        public void NavigateToTransferBetweenAccounts(Form currentForm, Customer customer)
        {
            currentForm.Hide();

            TransferBetweenAccounts transferBetweenAccountsForm = new TransferBetweenAccounts(customer);

            // Show the newForm and close the current form
            transferBetweenAccountsForm.FormClosed += (s, args) => currentForm.Close();
            transferBetweenAccountsForm.Show();
        }
    }
}