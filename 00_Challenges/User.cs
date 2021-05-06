using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges
{

//Create a User class

//Give the user a FirstName, LastName, ID (an integer, with no setter), and BirthDate properties.

//Create a blank constructor and a full constructor for this class.

//Bonus: Create a method that returns the full name of the user.

//Double Bonus: Create a method that returns the age of the user in years.


    //class = noun

    public class User
    {
        //put empty constractors at the top.. DECLARE an empty one... So the first person will be null
        public User() { }

        // full  constructor 
        public User(string firstName, string lastName, int iD, string email, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = iD;
            Email = email;
            BirthDate = birthDate;
        }

        public string FirstName { get; set; } // property
        public string LastName { get; set; }
        private int _ID;
        public int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                _ID = value;
            }
        }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public string FullName()
        {
                return $"{FirstName} {LastName}";
        }

        public int Age
        {
            get
            {
                TimeSpan ageSpan = DateTime.Now - BirthDate;
                double totalAgeInYears = ageSpan.TotalDays / 365.25;
                int yearsOld = Convert.ToInt32(Math.Floor(totalAgeInYears));
                return yearsOld;
            }
        }
    }
}
