using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BankingApp
{
    public partial class ManageCustomers : Form
    {
        Controller controller = new Controller();
        UtilsController utlisController = new UtilsController();

        Customer selectedCustomer;

        public ManageCustomers()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            showCustomersInfoListBox.Items.Clear();
            comboBoxIsStaff.SelectedIndex = -1;
            comboBoxIsStaff.DropDownStyle = ComboBoxStyle.DropDownList;

            updateCustomerButton.Enabled = false;
            deleteCustomerButton.Enabled = false;
            manageCustomerAccountsButton.Enabled = false;

            this.MaximizeBox = false;
            customerNameTextBox.MaxLength = 20;
            customerPhoneTextBox.MaxLength = 12;

            resetFormInputs();
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            string name =customerNameTextBox.Text.Trim();

            bool staff = comboBoxIsStaff.Text == "Yes" ? true : false;

            //if (!string.IsNullOrEmpty(name) && name.Trim().Length > 0)
            if (IsValidName(name))
            {
                try
                {
                    if (name.Length > 20)
                    {
                        //Validation if input length
                        throw new CustomException("Please enter a valid name with no more than 20 characters!");
                    }
                }
                catch (CustomException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    customerNameTextBox.Clear();
                    return;
                }

                if (isValidLongNumber(customerPhoneTextBox.Text))
                {
                    long phone = long.Parse(customerPhoneTextBox.Text);

                    try
                    {
                        if (phone.ToString().Length > 12)
                        {
                            //Validation if input length
                            throw new CustomException("Please enter a valid phone number with up to 12 digits!");
                        }
                    }
                    catch (CustomException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        customerPhoneTextBox.Clear();
                        return;
                    }

                    Customer new_customer = new Customer(name, phone, staff);
                    controller.AddCustomer(new_customer);

                    resetFormInputs();
                    MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("Please enter a valid phone number (only digits)!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    customerPhoneTextBox.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid name with letters only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                customerNameTextBox.Clear();
            }
        }

        private void updateCustomerButton_Click(object sender, EventArgs e)
        {
            selectedCustomer.Name = customerNameTextBox.Text.Trim();
            selectedCustomer.Staff = comboBoxIsStaff.SelectedIndex == 1 ? true : false;

            if (IsValidName(selectedCustomer.Name))
            {

                try
                {
                    if (selectedCustomer.Name.Length > 20)
                    {
                        //Validation if input length
                        throw new CustomException("Please enter a valid name with no more than 20 characters!");
                    }
                }
                catch (CustomException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    customerNameTextBox.Clear();
                    return;
                }

                if (isValidLongNumber(customerPhoneTextBox.Text))
                {
                    selectedCustomer.Phone = long.Parse(customerPhoneTextBox.Text);

                    try
                    {
                        if (selectedCustomer.Phone.ToString().Length > 12)
                        {
                            //Validation if input length
                            throw new CustomException("Please enter a valid phone number with up to 12 digits!");
                        }
                    }
                    catch (CustomException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        customerPhoneTextBox.Clear();
                        return;
                    }

                    controller.UpdateCustomer(selectedCustomer);

                    resetFormInputs();
                    MessageBox.Show("Customer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("Please enter a valid phone number (only digits)!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    customerPhoneTextBox.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid name with letters only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                customerNameTextBox.Clear();
            }
        }

        private void deleteCustomerButton_Click(object sender, EventArgs e)
        {
            controller.DeleteCustomer(selectedCustomer);

            resetFormInputs();
            MessageBox.Show("Customer deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void showCustomersInfoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (showCustomersInfoListBox.SelectedIndex != -1)
            {
                selectedCustomer = (Customer)showCustomersInfoListBox.SelectedItem;
                customerNameTextBox.Text = selectedCustomer.Name;
                customerPhoneTextBox.Text = selectedCustomer.Phone.ToString();
                comboBoxIsStaff.SelectedIndex = selectedCustomer.Staff ? 1 : 0;
            }
            enablDisableButtons();
        }

        private bool IsValidName(string name)
        {
            // Regex pattern to allow only letters with a space between the first name and surname
            string pattern = @"^[A-Za-z]+(?:\s[A-Za-z]+)?$";

            // Check if the input matches the pattern
            return Regex.IsMatch(name, pattern);
        }

        private bool isValidLongNumber(string num)
        {
            return long.TryParse(num, out _);
        }

        private void resetFormInputs()
        {
            customerNameTextBox.Clear();
            customerPhoneTextBox.Clear();
            comboBoxIsStaff.SelectedIndex = -1;
            // comboBoxIsStaff.DropDownStyle = ComboBoxStyle.DropDownList;

            showCustomersInfoListBox.Items.Clear();

            // Deserialize and load UserData
            controller.DeserializeCustomerData();

            // Display loaded data
            if (controller.CustomersList.Count <= 0)
            {
                showCustomersInfoListBox.Items.Add("No Customer in the List!");
            }
            else
            {
                //showCustomersInfoListBox.Items.Add("Id\t\tName\t\tPhone\t\tStaff");
                //showCustomersInfoListBox.Items.Add("-------------------------------------------------------------------");
                foreach (var customer in controller.CustomersList)
                {
                    showCustomersInfoListBox.Items.Add(customer);
                }
            }

            enablDisableButtons();
        }

        private void enablDisableButtons()
        {
            if (showCustomersInfoListBox.SelectedIndex != -1)
            {
                updateCustomerButton.Enabled = true;
                deleteCustomerButton.Enabled = true;
                addCustomerButton.Enabled = false;
                manageCustomerAccountsButton.Enabled = true;

            }
            else
            {
                updateCustomerButton.Enabled = false;
                deleteCustomerButton.Enabled = false;
                addCustomerButton.Enabled = true;
                manageCustomerAccountsButton.Enabled = false;
            }
        }

        private void manageCustomerAccountsButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            utlisController.NavigateToAddAccounts(this, selectedCustomer);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            resetFormInputs();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            utlisController.Logout(this);
        }
    }
}