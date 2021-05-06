using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Conditionals
{
    [TestClass]
    public class Switch
    {
        [TestMethod]
        public void SwitchCases()
        {
            int input = 1;

            switch (input)  //switch value is evaulting the input in this case
            {
                case 1: //you can stack multiple cases, which is why the "break;" is very important to break that switch evaultion 
                    Console.WriteLine("Hello");
                    break;
                case 2:
                    Console.WriteLine("World");
                    break;
                case 55:
                    Console.WriteLine("Huh");
                    break;
                default: //defaut is like a else statement
                    Console.WriteLine("What are you doing?"); //would happen if the input does not match any of the cases
                    break;
            }
        }
    }
}
