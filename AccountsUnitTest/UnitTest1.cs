using BankingApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AccountsUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EverydayAccount_NormalDeposit()
        {
            double currentBalance = 1000;
            double depositAmount = 200;
            double expectedResult = 1200;

            // Arrange
            EverydayAccount everydayAccount = new EverydayAccount(currentBalance);

            // Act
            everydayAccount.Deposit(depositAmount);

            // Assert
            Assert.AreEqual(expectedResult, everydayAccount.Balance);
        }

        [TestMethod]
        public void EverydayAccount_NegativeAmountDepositExceptionThrown()
        {
            double currentBalance = 1000;
            double depositAmount = -200;

            // Arrange
            EverydayAccount everydayAccount = new EverydayAccount(currentBalance);

            // Assert
            Assert.ThrowsException<NegativeInputException>(() => everydayAccount.Deposit(depositAmount));
        }

        [TestMethod]
        public void EverydayAccount_NormalWithdraw()
        {
            double currentBalance = 1000;
            double withdrawAmount = 200;
            double expectedResult = 800;

            // Arrange
            EverydayAccount everydayAccount = new EverydayAccount(currentBalance);

            // Act
            everydayAccount.Withdraw(withdrawAmount);

            // Assert
            Assert.AreEqual(expectedResult, everydayAccount.Balance);
        }

        [TestMethod]
        public void EverydayAccount_NegativeWithdrawExceptionThrown()
        {
            double currentBalance = 1000;
            double withdrawAmount = -200;

            // Arrange
            EverydayAccount everydayAccount = new EverydayAccount(currentBalance);

            // Assert
            Assert.ThrowsException<NegativeInputException>(() => everydayAccount.Withdraw(withdrawAmount));
        }

        [TestMethod]
        public void EverydayAccount_InsufficientWithdrawaExceptionThrown()
        {
            double currentBalance = 1000;
            double withdrawAmount = 1500;

            // Arrange
            EverydayAccount everydayAccount = new EverydayAccount(currentBalance);

            // Assert
            Assert.ThrowsException<InsufficientFundsException>(() => everydayAccount.Withdraw(withdrawAmount));
        }

        [TestMethod]
        public void EverydayAccount_AccountInfo()
        {
            double currentBalance = 1000;
            
            // Arrange
            EverydayAccount everydayAccount = new EverydayAccount(currentBalance);

            // Expected Result
            string expectedResult = $"Account Id: {everydayAccount.AccountId}, Type: {everydayAccount.Type}, Balance: {everydayAccount.Balance}";

            // Assert
            Assert.AreEqual(expectedResult, everydayAccount.AccountInfo());
        }

        [TestMethod]
        public void EverydayAccount_CalculateInterest()
        {
            double currentBalance = 1000;

            // Arrange
            EverydayAccount everydayAccount = new EverydayAccount(currentBalance);

            // Expected Result
            double expectedResult = 0;
 
            // Assert
            Assert.AreEqual(expectedResult, everydayAccount.CalculateInterest());
        }

        [TestMethod]
        public void InvestmentAccount_NormalDeposit()
        {
            double currentBalance = 1000;
            double depositAmount = 200;
            double expectedResult = 1200;

            // Arrange
            InvestmentAccount investmentAccount = new InvestmentAccount(currentBalance);

            // Act
            investmentAccount.Deposit(depositAmount);

            // Assert
            Assert.AreEqual(expectedResult, investmentAccount.Balance);
        }

        [TestMethod]
        public void InvestmentAccount_NegativeAmountDepositExceptionThrown()
        {
            double currentBalance = 1000;
            double depositAmount = -200;

            // Arrange
            InvestmentAccount investmentAccount = new InvestmentAccount(currentBalance);

            // Assert
            Assert.ThrowsException<NegativeInputException>(() => investmentAccount.Deposit(depositAmount));
        }

        [TestMethod]
        public void InvestmentAccount_NormalWithdraw()
        {
            double currentBalance = 1000;
            double withdrawAmount = 200;
            double expectedResult = 800;

            // Arrange
            InvestmentAccount investmentAccount = new InvestmentAccount(currentBalance);

            // Act
            investmentAccount.Withdraw(withdrawAmount);

            // Assert
            Assert.AreEqual(expectedResult, investmentAccount.Balance);
        }

        [TestMethod]
        public void InvestmentAccount_FailedTransactionFee()
        {
            //Customer class object
            Customer customer_2 = new Customer("Johnn", 1234567, false);

            double currentBalance = 1000;
            double withdrawAmount = 1100;
            double expectedResult = 990; // $10 failed fee

            // Arrange
            InvestmentAccount investmentAccount = new InvestmentAccount(currentBalance);
            investmentAccount.AssociatedCustomer = customer_2;

            // Act
            if (withdrawAmount <= 0)
            {
                investmentAccount.ChargeFailedTransactionFee();
            }
            else if (withdrawAmount > currentBalance)
            {
                investmentAccount.ChargeFailedTransactionFee();
            }else
            {
                investmentAccount.Withdraw(withdrawAmount);
            }

            // Assert
            Assert.AreEqual(expectedResult, investmentAccount.Balance);
        }

        [TestMethod]
        public void InvestmentAccount_FailedTransactionFeeForStaff()
        {
            //Customer class object
            Customer customer_2 = new Customer("Jhon", 1234567, true);

            double currentBalance = 1000;
            double withdrawAmount = 1100;
            double expectedResult = 995; // $5 failed fee for Staff

            // Arrange
            InvestmentAccount investmentAccount = new InvestmentAccount(currentBalance);
            investmentAccount.AssociatedCustomer = customer_2;

            // Act
            // Act
            if (withdrawAmount <= 0)
            {
                investmentAccount.ChargeFailedTransactionFee();
            }
            else if (withdrawAmount > currentBalance)
            {
                investmentAccount.ChargeFailedTransactionFee();
            }
            else
            {
                investmentAccount.Withdraw(withdrawAmount);
            }

            // Assert
            Assert.AreEqual(expectedResult, investmentAccount.Balance);
        }

        [TestMethod]
        public void InvestmentAccount_NegativeWithdrawExceptionThrown()
        {
            double currentBalance = 1000;
            double withdrawAmount = -200;

            // Arrange
          InvestmentAccount investmentAccount = new InvestmentAccount(currentBalance);

            // Assert
            Assert.ThrowsException<NegativeInputException>(() => investmentAccount.Withdraw(withdrawAmount));
        }

        [TestMethod]
        public void InvestmentAccount_InsufficientWithdrawExceptionThrown()
        {
            double currentBalance = 1000;
            double withdrawAmount = 1500;

            // Arrange
            InvestmentAccount investmentAccount = new InvestmentAccount(currentBalance);


            // Assert
            Assert.ThrowsException<InsufficientFundsException>(() => investmentAccount.Withdraw(withdrawAmount));
        }

        [TestMethod]
        public void InvestmentAccount_AccountInfo()
        {
            double currentBalance = 1000;

            // Arrange
            InvestmentAccount investmentAccount = new InvestmentAccount(currentBalance);

            // Expected Result
            string expectedResult = $"Account Id: {investmentAccount.AccountId}, Type: {investmentAccount.Type}, Balance: {investmentAccount.Balance}";

        // Assert
        Assert.AreEqual(expectedResult, investmentAccount.AccountInfo());
        }

        [TestMethod]
        public void InvestmentAccount_CalculateInterest()
        {
            double currentBalance = 1000;

            // Arrange
            InvestmentAccount investmentAccount = new InvestmentAccount(currentBalance);

            // Expected Result
            double expectedResult = 40;

            // Assert
            Assert.AreEqual(expectedResult, investmentAccount.CalculateInterest());
        }

        [TestMethod]
        public void InvestmentAccount_AddInterest()
        {
            double currentBalance = 1000;

            // Arrange
            InvestmentAccount investmentAccount = new InvestmentAccount(currentBalance);
            double interest = investmentAccount.CalculateInterest();
            investmentAccount.AddInterest(interest);

            // Expected Result
            double expectedResult = 1040;

            // Assert
            Assert.AreEqual(expectedResult, investmentAccount.Balance);
        }

        [TestMethod]
        public void OmniAccount_NormalDeposit()
        {
            double currentBalance = 1000;
            double depositAmount = 200;
            double expectedResult = 1200;

            // Arrange
            OmniAccount omniAccount = new OmniAccount(currentBalance);

            // Act
            omniAccount.Deposit(depositAmount);

            // Assert
            Assert.AreEqual(expectedResult, omniAccount.Balance);
        }


        [TestMethod]
        public void OmniAccount_NegativeAmountDepositExceptionThrown()
        {
            double currentBalance = 1000;
            double depositAmount = -200;

            // Arrange
            OmniAccount omniAccount = new OmniAccount(currentBalance);

            // Assert
            Assert.ThrowsException<NegativeInputException>(() => omniAccount.Deposit(depositAmount));
        }

        [TestMethod]
        public void OmniAccount_NormalWithdrawal()
        {
            double currentBalance = 1000;
            double withdrawAmount = 200;
            double expectedResult = 800;

            // Arrange
            OmniAccount omniAccount = new OmniAccount(currentBalance);

            // Act
            omniAccount.Withdraw(withdrawAmount);

            // Assert
            Assert.AreEqual(expectedResult, omniAccount.Balance);
        }

        [TestMethod]
        public void OmniAccount_OverdraftWithdrawal()
        {
            double currentBalance = 1000;
            double withdrawAmount = 1100;
            double expectedResult = -100;

            // Arrange
            OmniAccount omniAccount = new OmniAccount(currentBalance);

            // Act
            omniAccount.Withdraw(withdrawAmount);

            // Assert
            Assert.AreEqual(expectedResult, omniAccount.Balance);
        }

        [TestMethod]
        public void OmniAccount_FailedTransactionFee()
        {
            //Customer class object
            Customer customer_1 = new Customer("Steve", 123456, false);

            double currentBalance = 1000;
            double withdrawAmount = 1101;
            double expectedResult = 990;

            // Arrange
            OmniAccount omniAccount = new OmniAccount(currentBalance);
            omniAccount.AssociatedCustomer = customer_1;

            // Act
            if (withdrawAmount <= 0)
            {
                omniAccount.ChargeFailedTransactionFee();
            }
            else if (withdrawAmount > (currentBalance + 100))
            {
                omniAccount.ChargeFailedTransactionFee();
            }
            else
            {
                omniAccount.Withdraw(withdrawAmount);
            }

            // Assert
            Assert.AreEqual(expectedResult, omniAccount.Balance);
        }

        [TestMethod]
        public void OmniAccount_FailedTransactionFeeForStaff()
        {
            //Customer class object
            Customer customer_1 = new Customer("Steve", 123456, true);

            double currentBalance = 1000;
            double withdrawAmount = 1101;
            double expectedResult = 995;

            // Arrange
            OmniAccount omniAccount = new OmniAccount(currentBalance);
            omniAccount.AssociatedCustomer = customer_1;

            // Act
            if (withdrawAmount <= 0)
            {
                omniAccount.ChargeFailedTransactionFee();
            }
            else if (withdrawAmount > (currentBalance + 100))
            {
                omniAccount.ChargeFailedTransactionFee();
            }
            else
            {
                omniAccount.Withdraw(withdrawAmount);
            }

            // Assert
            Assert.AreEqual(expectedResult, omniAccount.Balance);
        }

        [TestMethod]
        public void OmniAccount_NegativeWithdrawExceptionThrown()
        {
            double currentBalance = 1000;
            double withdrawAmount = -200;

            // Arrange
            OmniAccount omniAccount = new OmniAccount(currentBalance);

            // Assert
            Assert.ThrowsException<NegativeInputException>(() => omniAccount.Withdraw(withdrawAmount));
        }

        [TestMethod]
        public void OmniAccount_InsufficientWithdrawExceptionThrown()
        {
            double currentBalance = 1000;
            double withdrawAmount = 1101;

            // Arrange
            OmniAccount omniAccount = new OmniAccount(currentBalance);

            // Assert
            Assert.ThrowsException<InsufficientFundsException>(() => omniAccount.Withdraw(withdrawAmount));
        }

        [TestMethod]
        public void OmniAccount_AccountInfo()
        {
            double currentBalance = 1000;

            // Arrange
            OmniAccount omniAccount = new OmniAccount(currentBalance);

            // Expected Result
            string expectedResult = $"Account Id: {omniAccount.AccountId}, Type: {omniAccount.Type}, Balance: {omniAccount.Balance}";

        // Assert
        Assert.AreEqual(expectedResult, omniAccount.AccountInfo());
        }

        [TestMethod]
        public void OmniAccount_CalculateInterest()
        {
            double currentBalance = 1100;

            // Arrange
            OmniAccount omniAccount = new OmniAccount(currentBalance);

            // Expected Result
            double expectedResult = 4;

            // Assert
            Assert.AreEqual(expectedResult, omniAccount.CalculateInterest());
        }

        [TestMethod]
        public void OmniAccount_AddInterest()
        {
            double currentBalance = 1100;

            // Arrange
            OmniAccount omniAccount = new OmniAccount(currentBalance);
            double interest = omniAccount.CalculateInterest();
            omniAccount.AddInterest(omniAccount.CalculateInterest());


            // Expected Result
            double expectedResult = 1104;

            // Assert
            Assert.AreEqual(expectedResult, omniAccount.Balance);
        }

        [TestMethod]
        public void OmniAccount_InvalidCalculateInterest()
        {
            double currentBalance = 900;

            // Arrange
            OmniAccount omniAccount = new OmniAccount(currentBalance);

            // Expected Result
            double expectedResult = 0;

            // Assert
            Assert.AreEqual(expectedResult, omniAccount.CalculateInterest());
        }
    }      
}