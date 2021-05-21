using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _00_Challenges
{
    [TestClass]
    public class Calculator
    {
        public double Add (double numOne, double numTwo) //This is a method
        {
            return numOne + numTwo; 
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
        public double Add(double[] numbers)
        {
            double total = 0;
            foreach (double number in numbers)
            {
                total += number;
            }
            return total;
        }

        public double Sub(double [] numbers)
        {
            double total = 0;
            for (int i = 0; i < numbers.Length; ++i)
            {
                if (i==0)
                {
                    total = numbers[i];
                }
                else
                {
                    total -= numbers[i];
                }
            }
            return total;
        }

        //public double TestSub(double[] numbers)
        //{
        //    double total = 0;
        //    foreach (double number in numbers)
        //    {
        //        total 

        //        total -= number;
        //    }
        //    return total;
        //}



        //Calculator Tests
        [TestMethod]
        public void Add()
        {
            Calculator calc = new Calculator();
            double totalSum = Add(2, 4);
            Assert.AreEqual(6, totalSum);
            Assert.AreEqual(11, calc.Add(5, 6));
            Assert.AreEqual(113, calc.Add(new double[] { 32, 12, 59, 10 }));

        } 

        [TestMethod]
        public void Sub()
        {
            double totalSub = Subtract(10, 3);
            Assert.AreEqual(7, totalSub);
        }

        //[TestMethod]
        //public void TestSubMethod()
        //{
        //    Calculator calc = new Calculator();
        //    Assert.AreEqual(1, calc.TestSub(new double[] { 5, 3, 1 }));
        //}

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

        [TestMethod]
        public void MyTestMethod()
        {
            int a = 7;
            int b = 2;
            int sum = a / b;

            Console.WriteLine(sum);
            Console.ReadLine();
        }


    }
}
