using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Drawing.Text;

namespace BankingApp
{
    [Serializable]
    internal class Controller
    {
        private List<Customer> customersList = new List<Customer>();

        //Property with a getter to access customerList
        public IReadOnlyList<Customer> CustomersList => customersList.AsReadOnly();

        private const string FilePath = "customersDataList.txt"; // Keep the file extension as .txt - For saving Binary Data

        public Controller() {
            // Loading existing data during apllication startup to target auto increment id from the saved binary file
            DeserializeCustomerData();
        }
        public void AddCustomer(Customer customer)
        {
            customersList.Add(customer);

            // Add the customer to the list and then serialize
            SerializeCustomersData();
        }

        public void UpdateCustomer(Customer updateCustomer)
        {
            Customer customerToUpdate = FindCustomerById(updateCustomer.CustomerId);
            if (customerToUpdate != null)
            {
                customerToUpdate.Name = updateCustomer.Name;
                customerToUpdate.Phone = updateCustomer.Phone;
                customerToUpdate.Staff = updateCustomer.Staff;
                customerToUpdate.Accounts = updateCustomer.Accounts;

                // Serialize and save the CustomerData
                SerializeCustomersData();
            }
        }

        public void DeleteCustomer(Customer deleteCustomer)
       {
            Customer customerToDelete = FindCustomerById(deleteCustomer.CustomerId);
            if (customerToDelete != null)
            {
                customersList.Remove(customerToDelete);

                // Serialize and delete the CustomerData
                SerializeCustomersData();
            }
       }

        public Customer FindCustomerById(int customerId)
        {
            return customersList.FirstOrDefault(customer => customer.CustomerId == customerId);
        }

        // Serialization
        public void SerializeCustomersData()
        {
            try
            {
                using (FileStream fs = new FileStream(FilePath, FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, customersList);
                    // Console.WriteLine("Customer Data saved through serialization successfully!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                // MessageBox.Show($"Error during serialization: {ex.Message}");
            }
        }

        // Deserialization
        public void DeserializeCustomerData()
        {
            try
            {
                if (File.Exists(FilePath))
                {
                    FileInfo fileInfo = new FileInfo(FilePath);

                    if (fileInfo.Length > 0)
                    {
                        using (FileStream fs = new FileStream(FilePath, FileMode.Open))
                        {
                            BinaryFormatter formatter = new BinaryFormatter();
                            customersList = (List<Customer>)formatter.Deserialize(fs);
                            // Console.WriteLine("Customer Data retrieved from deserialization successfully!");
                        }
                    }
                    else
                    {
                       // MessageBox.Show("File is empty. No data to deserialize.");
                        return;
                    }
                }
                else
                {
                   // MessageBox.Show("File does not exist. No data to deserialize.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                // MessageBox.Show($"Error during deserialization: {ex.Message}");
            }
        }
    }
}