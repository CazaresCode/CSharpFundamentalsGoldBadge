using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02_Operators
{
    [TestClass]
    public class Arithmetic
    {
        [TestMethod]
        public void Operators() //avoid naming class and types
        {
            int a = 22;
            int b = 15;

            //Addition
            int sum = a + b;
            Console.WriteLine(sum); // 37

            //Subtraction
            int difference = a - b;
            Console.WriteLine(difference); // 7

            //Multiplication 
            int product = a * b;
            Console.WriteLine(product); // 330

            //Division
            int quotient = a / b;
            Console.WriteLine(quotient); // 1 ... won't show the remainder because it is int. you need to change it to double here and up in the statement thingy

            //Remainder (modulus)
            int remainder = a % b;
            Console.WriteLine(remainder); // 7
        }
        [TestMethod]
        public void MyTestMethod()
        {
            for (int y = 1; y <= 5; y++)
            {
                for (int x = 1; x <= 12; x++)
                {
                    Console.WriteLine($" {x} * {y} = { x * y } ");
                }
            }
        }

    }
}
