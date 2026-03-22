using BankAccountNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Principal;
namespace BankTests
{
    [TestClass]
    public class BankAccountTests
    {
        //[TestMethod]
        //public void Debit_WithValidAmount_UpdatesBalance()
        //{
        //    // Arrange
        //    double beginningBalance = 11.99;
        //    double debitAmount = 4.55;
        //    double expected = 7.44;
        //    BankAccount account = new BankAccount("Mr.Roman Abramovich&quot", beginningBalance);
        //    // Act
        //    account.Debit(debitAmount);
        //    // Assert
        //    double actual = account.Balance;
        //    Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        //}

        //[TestMethod]
        //public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        //{
        //    // Arrange
        //    double beginningBalance = 11.99;
        //    double debitAmount = -100.00;
        //    BankAccount account = new BankAccount("Mr.Roman Abramovich&quot", beginningBalance);
        //    // Act and assert
        //    Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));
        //}

        //[TestMethod]
        //public void Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange()
        //{
        //    // Arrange
        //    double beginningBalance = 11.99;
        //    double debitAmount = 42536786.00;          
        //    BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

        //    // Act & Assert
        //    Assert.ThrowsException<ArgumentOutOfRangeException>(() => account.Debit(debitAmount));
        //}

        //[TestMethod]
        //public void Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange()
        //{
        //    Arrange
        //    double beginningBalance = 11.99;
        //    double debitAmount = 20.0;
        //    BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

        //    Act
        //    try
        //    {
        //        account.Debit(debitAmount);
        //    }
        //    catch (System.ArgumentOutOfRangeException e)
        //    {
        //        Assert
        //        StringAssert.Contains(e.Message, BankAccount.DebitAmountExceedsBalanceMessage);
        //    }
        //}

        //[TestMethod]

        //public void Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange()
        //{
        //    // Arrange
        //    double beginningBalance = 11.99;
        //    double debitAmount = 20.0;
        //    BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

        //    // Act
        //    try
        //    {
        //        account.Debit(debitAmount);
        //    }
        //    catch (System.ArgumentOutOfRangeException e)
        //    {
        //        // Assert
        //        StringAssert.Contains(e.Message, BankAccount.DebitAmountExceedsBalanceMessage);
        //        return;
        //    }

        //    Assert.Fail("The expected exception was not thrown.");
        //}

        [TestMethod]
        public void Credit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 11.99;
            double creditAmount = 50.00;
            double expected = 61.99;

            BankAccount account = new BankAccount("Test User", beginningBalance);

            // Act
            account.Credit(creditAmount);

            // Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "balance does not match the expected");
        }

        [TestMethod]
        public void Credit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 11.99;
            double creditAmount = -25.00;
            BankAccount account = new BankAccount("Test User", beginningBalance);

            // Act
            try
            {
                account.Credit(creditAmount);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                // Assert
                StringAssert.Contains(e.Message, "amount");
                return;
            }
            Assert.Fail("The expected exception was not thrown");
        }

    }
}
