using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Calculator //REMEMBER TO ADD "public" WHEN YOU OPEN UP A NEW CLASS
    {

        // write a method that takes in two numbers and returns the sum of those two numbers as a double.

        // we pass the arguements

        public double GetSum(double numOne, double numTwo) //this is METHOD
        {
            double sumSolution = (numOne + numTwo);
            return sumSolution; //this is shorthand, meaning you don't really need the thing above for this case.

        }
     

        //subtraction
        //mutilplication
        //division

        public int CalculateAge(DateTime birthday)
        {
            TimeSpan ageSpan = DateTime.Now - birthday;
            double totalAgeInDays = ageSpan.TotalDays;
            double totalAgeinYears = totalAgeInDays / 365.25;
            int years = Convert.ToInt32(Math.Floor(totalAgeinYears));
            return years;
        }
    }
}
