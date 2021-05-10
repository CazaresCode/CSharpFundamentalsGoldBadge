using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _00_Challenges
{
    [TestClass]
    public class W1D3Part2
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Declare and initialize variables that hold your first name, last name, and age
            string firstName = "Alexandro";
            string lastName = "Cazares";
            DateTime age = new DateTime(1993, 08, 26);


            //Declare and initialize an array that holds  a collection of at least four of your favorite book or movie titles

            List<string> favMovies = new List<string>();
            favMovies.Add("HP:1" +
                 "HP:2" +
                 "Hp:3" +
                 "HP: 4");

            string anotherExampleString = "Hello World";
            string[] favBookz = { anotherExampleString, "hello", "yes", "okay", "1" };

        

            //Make a list to hold dates.Include on that list the current date and time.

            //Write out to the Console the values calculated by your age variable and the number 7.

            //Write out a collection of conditionals that evaluates a new variable for how many hours of sleep the user gets.
            //You can just initialize this variable for now, it does not have to be actually given by a user.


            //If the hours slept is greater or equal to 10, write to the console "Wow that's a lot of sleep!"
            //If the hours is greater than 8 but less than 10, write to the console "You should be pretty rested"
            //If the hours is greater than 4 but less than 8, output "Bummer"
            //For any other condition output "Oh man, get some sleep!"


            //Write out a switch case that evaluates a variable that holds the value for how the user's day has been.
            //Have a case for: "Great", "Good", "Okay", "Bad", ":(" and output a response to the Console for each.
        }
    }

    // Parts of a method
    // 1. Access Modifier (public, private, internal)
    // 2. Return Type (local variable)
    // 3. method Signature (name and parameters)
    // 4. body


    class MethodsClass
    {
        public void GetLargerNumber(int numOne, int numTwo)
        {
            if (numOne > numTwo)
            {
                Console.WriteLine(numOne);
            }
            else if(numTwo > numOne)
            {
                Console.WriteLine(numTwo);
            }
            else
            {
                Console.WriteLine("numbers are the same");
            }

        }
        public int GetLargestNum(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        // Write a method that takes in a string and returns the parsed value as an integer.
        public int ParseIntput(string input)
        {
            int intput = int.Parse(input);
            return intput;
        }

        // Write a method that takes in a birthday and writes to the console how old the user is.
        public void CalculateAge(DateTime birthday)
        {
            TimeSpan lifeSpan = DateTime.Now - birthday;
            int years = lifeSpan.Days / 365;
            Console.WriteLine($"You are {years} years old.");
        }

        // Write a method that takes in two numbers of type int, divides the first by the second, and then returns the quotient as a double.
        public double Maths(int a, int b)
        {
            double quotient = a / b;
            return quotient; // => better yet, return a /b .... it is implicitly a double because of the return type.

            //another solution
            //int quotient = a / b;
            //return Convert.ToDouble(quotient);
        }

        // Write a method that takes in a name and then writes out a greeting with the name included.
        public void Greeting(string name)
        {
            Console.WriteLine($"Hello {name}, how are you?");
        }

    }

}
