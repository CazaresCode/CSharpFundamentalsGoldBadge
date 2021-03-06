using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Person
    {
        public Person() { }

        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }

        // Backing field, last name
        private string _lastName;
        public string LastName
        {
            get
            {
                //returns the information from the _lastName property
                return _lastName;
            }
            set
            {
                //value comes from LastName, sets private field _lastName as LastName
                _lastName = value;
            }
        }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public int Age
        {
            get
            {
                TimeSpan ageSpan = DateTime.Now - DateOfBirth;
                double totalAgeInYears = ageSpan.TotalDays / 365.25; //make it a double because of the int so we can use it
                int yearsOld = Convert.ToInt32(Math.Floor(totalAgeInYears));
                return yearsOld;
            }
        }

        public DateTime DateOfBirth { get; set; }

        public int x;
        public int y;
        
        public Person(int x, int y)
        {
            this.x = x;
            this.x = y;
        }


        // Using the class as a type
        public Vehicle Transport { get; set; }
    }
}
