using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    [Serializable]
    public class Customer
    {
        Controller controller = new Controller();

        private static int customer_id = 101; // Static Id for customer id

        private int customerId;
        private string name;
        private long phone;
        private bool staff;

        public int CustomerId 
        { 
            get { return customerId; }
            set { customerId = value; }
        }

        public string Name 
        { 
            get { return name; } 
            set { name = value; }
        }

        public long Phone 
        {
            get { return phone; }
            set { phone = value; }
        }

        public bool Staff 
        {
            get { return staff; }
            set { staff = value; } 
        }

        // List to store customer's accounts
        public List <Account> Accounts { get; set; } // List to store different Accounts

        // Constructor
        public Customer (string name, long phone, bool staff = true ) 
        {
            Customer lastCustomer = controller.CustomersList.LastOrDefault();

            CustomerId = lastCustomer != null ? lastCustomer.CustomerId + 1 : customer_id++;  // Auto increment id from serialization data
            Name = name;
            Phone = phone;
            Staff = staff;

            //Intialize the list of accounts
            Accounts = new List<Account>();
        }

        public void AddAccount(Account account)
        {
            Accounts.Add(account);
        }

        public override string ToString()
        {
           return $"Id: {CustomerId}, Name: {Name}, Phone: {Phone}, Staff: {(Staff ? "Yes" : "No")}";
        }
    }
}