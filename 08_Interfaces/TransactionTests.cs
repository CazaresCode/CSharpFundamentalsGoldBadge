using _08_Interfaces.Currency;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _08_Interfaces
{
    [TestClass]
    public class TransactionTests
    {
        private decimal _debt;

        private void PayDebt(ICurrency payment)
        {
            // _debt = _debt - payment.Value;
            _debt -= payment.Value; //shorthand
            Console.WriteLine($"You have ${payment.Value} towards your debt.");
        }
        [TestInitialize]
        public void Arrange()
        {
            _debt = 9000.01m;
        }

        [TestMethod]
        public void PayDebtTest()
        {
            PayDebt(new Dollar());
            PayDebt(new ElectronicPayment(315.52m));

            // Our debt minus our ePayment + $1
            decimal expectedDebt = 9000.01m - 316.52m;

            Assert.AreEqual(expectedDebt, _debt);
        }

        [TestMethod]
        public void InjectingIntoConstructors()
        {
            // Creating new instances of our Icurrency interface objects.
            var dollar = new Dollar();
            var ePay = new ElectronicPayment(243.71m);

            // "Injecting" them into Transaction class for that _currency field.
            var firstTransaction = new Transaction(dollar);
            var secondTransaction = new Transaction(ePay);

            Console.WriteLine(firstTransaction.GetTransactionType());
            Console.WriteLine(secondTransaction.GetTransactionType());

            Console.WriteLine(secondTransaction.GetTransactionAmount());
        }

        [TestMethod]
        public void MoreExamples()
        {
            var list = new List<Transaction>
            {
                new Transaction(new Dollar()),
                new Transaction(new ElectronicPayment(231.95m)),
                new Transaction(new Penny()),
                new  Transaction(new Dime()),
                new Transaction(new Dollar())
            };

            foreach (var tranaction in list)
            {
                // Readability
                var type = tranaction.GetTransactionType();
                var amount = tranaction.GetTransactionAmount();
                Console.WriteLine($"{type} {amount} {tranaction.DateOfTransaction}");
                
                // Inline ... single statement... inline like all on one line.
                Console.WriteLine($"You paid ${tranaction.GetTransactionAmount()} on {tranaction.DateOfTransaction}");
                Console.WriteLine();
            }
        }

    }
}
