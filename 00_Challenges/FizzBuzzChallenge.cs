using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _00_Challenges
{
    [TestClass]
    public class FizzBuzzChallenge
    {
        [DataTestMethod]
        [DataRow(100)]
        public void FizzBuzzChallengeMethod(int numToCountTo)
        {
            // 1. Starting Point
            // 2. Condition to check
            // 3. The body - what to do each iteration of the loop
            // 4. What to do after the body and before checking the condition again

            //    1             2               4
            for ( int i = 1; i <= numToCountTo; i++)
            {
                //3 everything inside the  { } is the body
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                Console.WriteLine(i);
                }
            }

        }
    }
}
