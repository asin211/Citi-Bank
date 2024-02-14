using System;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.MaximizeBox = false;
        }

        private void manageCustomersButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            ManageCustomers manageCustomersForm = new ManageCustomers();

            // Show the newForm and close the current form
            manageCustomersForm.FormClosed += (s, args) => this.Close();
            manageCustomersForm.Show();
        }

        private void customerLoginButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Customer Login coming soon!");
        }
    }
}