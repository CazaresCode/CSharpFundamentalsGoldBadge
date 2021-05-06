using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inheritance
{
    public abstract class Person // the keyword "abstract" is for inheritance ONLY... to be only inherited from!
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Person() { }

        // No FullName below because it is above and it is SET automatically
        public Person(string firstName, string lastName, string phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public abstract void WhoAmI(); //commented it out because of the keyword abstract.
        //{
        //    Console.WriteLine("I am a person");
        //}
    }

    //This is an example of Inheritance
    public class Customer : Person
    {
        public bool IsPremium { get; set; }

        public Customer() { }
        public Customer(bool isPremium)
        {
            IsPremium = isPremium;
        }

        public override void WhoAmI()
        {
            /*base.WhoAmI();*/ // The result here would be from the Person class, "I am a person" however you can comment this base in this line out so it doesnt show up.
            Console.WriteLine("I am a customer");
        }

    }

    public class Employee : Person
    {
        public int EmployeeNumber { get; set; }
        public DateTime HireDate { get; set; }
        public int YerasWithCompany
        {
            get
            {
                double totalTime = (DateTime.Now - HireDate).TotalDays / 365.25; //This is a shorter verison instead of three lines into 2.
                return Convert.ToInt32(Math.Floor(totalTime));
            }

        }

        public Employee(int employeeNumber)
        {
            EmployeeNumber = employeeNumber;
        }
        public Employee(int employeeNumber, DateTime hireDate, string firstName, string lastName, string phoneNumber, string email) : base(firstName, lastName, phoneNumber, email)
        {
            EmployeeNumber = employeeNumber;
            HireDate = hireDate;
        }

        public override void WhoAmI()
        {
            Console.WriteLine("I am an Employee");
            //base.WhoAmI();
        }
    }

    public class SalaryEmployee : Employee
    {
        public decimal Salary { get; set; }
        public SalaryEmployee(int employeeNumber, decimal salary) : base(employeeNumber)
        {
            Salary = salary;
        }
        public SalaryEmployee(decimal salary, int employeeNumber, DateTime hireDate, string firstName, string lastName, string phoneNumber, string email) : base(employeeNumber, hireDate, firstName, lastName, phoneNumber, email)
        {
            Salary = salary;
        }
    }
}
