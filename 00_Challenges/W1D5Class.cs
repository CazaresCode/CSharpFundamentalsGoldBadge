using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges
{
    public enum CourseType { Cyber, WebDev, SoftwareDev };
    public enum BadgeType { Gold, Blue, Red };
    public class Student
    {

        //MUST CREATE PROPERTIES
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public CourseType CourseType { get; set; }
        public decimal BalancedOwed { get; set; }
        public BadgeType TypeOfBadge { get; set; }
        public bool HasGraduated { get; set; }


        //Empty constructor
        public Student() { }

        //Special kind of method AKA Overloaded Constructor
        public Student(string firstName, string lastName, DateTime dateOfBirth, CourseType classTaking, decimal balancedOwed, BadgeType typeOfBadge, bool hasGraduated)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            CourseType = classTaking;
            BalancedOwed = balancedOwed;
            TypeOfBadge = typeOfBadge;
            HasGraduated = hasGraduated;
        }
    }

    //below, the first enum is the same class vairiables can be the same BUT different name for different uses/reasons?
    public enum CourseTaught { Cyber, WebDev, SoftwareDev };
    public class Instructor
    { 
        //THIS is forcing the input to HAVE an int value, which in this case you are avoiding the future headache IF there was no (int employeeNumber)
        //This is replacing the set from the properties from public int EmployeeNumber
        public Instructor(int employeeNumber)
        {
            EmployeeNumber = employeeNumber;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int EmployeeNumber { get; }
        public CourseTaught CourseTeaching { get; set; }



        public Instructor (string firstName, string lastName, DateTime dateOfBirth, int employeeNumber, CourseTaught courseTeaching)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            EmployeeNumber = employeeNumber;
            CourseTeaching = courseTeaching;
        }

    }
}
