using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Conditionals
{
    [TestClass]
    public class Ternary
    {
        [TestMethod]
        public void Ternaries()
        {
            int age = 31;
                          //condition   options of possible values
            bool isAdult = (age > 17) ? true : false; //you don't need () but helps to see it better
            Console.WriteLine(isAdult);

            int numOne = 10;
            int numTwo = (numOne == 10) ? 30 : 20; // answer is 30 because the condition THUS CHECKING THE CONDITION SO IT HAS TO HAVE A CONDITION is either true or it is not... if numOne was 11, then numTwo is checking to see if it is equal to 10, thus being the answer is 20. 

            Console.WriteLine(numTwo);

            Console.WriteLine((numTwo == 30) ? "True" : "False");
        }
    }
}
