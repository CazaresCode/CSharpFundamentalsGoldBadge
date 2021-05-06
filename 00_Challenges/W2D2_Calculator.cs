using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _00_Challenges
{
    [TestClass]
    public class Calculator
    {
        public double Add (double numOne, double numTwo) //This is a method
        {
            return numOne + numTwo; ;
        }

        public double Subtract (double numOne, double numTwo)
        {
            return numOne - numTwo; 
        }

        public double Multiply (double numOne, double numTwo)
        {
            return numOne * numTwo; 
        }

        public double Divison (double numOne, double numTwo)
        {
            return numOne / numTwo;
        }

        public string Percent (double a, double b)
        {
            double c = a / b;
            c *= 100;
            return $"{c}%";
        }

        //how to find a prop that would allow to add more numbers to do the addition and the other ones. 


        //Calculator Tests
        [TestMethod]
        public void Add()
        {
            Calculator calc = new Calculator();
            double totalSum = Add(2, 4);
            Assert.AreEqual(6, totalSum);
        }

        [TestMethod]
        public void Sub()
        {
            double totalSub = Subtract(10, 3);
            Assert.AreEqual(7, totalSub);
        }

        [TestMethod]
        public void Mul()
        {
            double totalMultiply = Multiply(3, 3);
            Assert.AreEqual(9, totalMultiply);
        }
        [TestMethod]
        public void Div()
        {
            double totalDiv = Divison(9, 3);
            Assert.AreEqual(3, totalDiv);
        }

        [TestMethod]
        public void Percent()
        {
            //DO A TEST HERE
        }
    }
}
