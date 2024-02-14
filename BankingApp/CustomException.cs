using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    public class CustomException : Exception
    {
        public CustomException(string message): base(message) { } // Custom Exception for throwing any specific error
    }

    // Null or Empty input
    public class InvalidInputNullException : Exception
    {
        public InvalidInputNullException() : base("Invalid input!") { }

        public InvalidInputNullException(string message) : base(message) { }
    }

    // Input 0 or less
    public class NegativeInputException : Exception
    {
        public NegativeInputException() : base("Please enter a valid amount greater than 0!") { }       

        public NegativeInputException(string message) : base(message) { }

    }

    // Insufficient balance 
    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException() : base("Insufficient funds for withdrawal!") { }

        public InsufficientFundsException(string message) : base(message) { }
    }
}