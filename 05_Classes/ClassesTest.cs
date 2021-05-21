using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _05_Classes
{
    [TestClass]
    public class ClassesTest
    {
        //Vehicle
        [TestMethod]
        public void VehiclePropertiesTests()
        {
            Vehicle firstVehicle = new Vehicle();
            firstVehicle.Make = "Honda";
            Console.WriteLine(firstVehicle.Make);

            firstVehicle.Model = "Accord";
            firstVehicle.Mileage = 125321.4;
            firstVehicle.TypeOfVehicle = VehicleType.Car;

            Console.WriteLine(firstVehicle.Model);
            Console.WriteLine(firstVehicle.Mileage);
            Console.WriteLine(firstVehicle.TypeOfVehicle);

            int code = 17;
            int quanitity = 55;
            int temp = code;
            code = quanitity;
            quanitity = temp;

            Console.WriteLine(code);
            Console.WriteLine(quanitity);

        }


        [TestMethod]
        public void VehicleMethodsTests()
        {
            Vehicle secondVehicle = new Vehicle();
            secondVehicle.TurnOn();
            Console.WriteLine(secondVehicle.IsRunning);
            secondVehicle.TurnOff();
            Console.WriteLine(secondVehicle.IsRunning);

            secondVehicle.IndicateRight();
            Console.WriteLine(secondVehicle.RightIndicator);
            Console.WriteLine(secondVehicle.LeftIndicator);
            secondVehicle.TurnOnHazards();
            Console.WriteLine(secondVehicle.RightIndicator);
            Console.WriteLine(secondVehicle.LeftIndicator);
        }

        [TestMethod]
        public void IndicatorVehicleTests()
        {
            Indicator indicator = new Indicator();
            //Cannot be set outside of class, private set 
            //indicator.IsFlashing = true;
            Console.WriteLine(indicator.isFlashing);
            indicator.TurnOn();
        }


        [TestMethod]
        public void VehicleConstructorTest()
        {
            Vehicle car = new Vehicle();
            car.Make = "Nissian";
            car.Model = "Skyline";
            car.Mileage = 50000;
            car.TypeOfVehicle = VehicleType.Car;

            Console.WriteLine(car.Make + " " + car.Model);

            Vehicle rocket = new Vehicle("Enterprise", "Galaxy", 100000, VehicleType.Plane);

            Console.WriteLine($" I rode on spacehip, it was the {rocket.Make}");

            rocket.Model = "Constellation";

            Console.WriteLine($"That ship is a {rocket.Model}");
        }

        //Greeter
        [TestMethod]
        public void GreeterMethodsTests()
        {
            Greeter greeterInstance = new Greeter(); //known as a new Greeter() object

            greeterInstance.SayHello("Brad");

            List<string> students = new List<string>();
            students.Add("Hannan");
            students.Add("Joel");
            students.Add("Jay");
            students.Add("Lauren");
            students.Add("Luis");

            foreach (string student in students)
            {
                greeterInstance.SayHello(student);
            }


            string greeting = greeterInstance.GetRandomGreeting();
            Console.WriteLine(greeting);
            greeterInstance.SaySomething(greeting); //a longer way to do the same thing above
        }

        [TestMethod]
        public void CalculatorTests()
        {
            Calculator calculatorInstance = new Calculator();

            double sum = calculatorInstance.GetSum(3.5, 100.9);
            Console.WriteLine(sum);

            int age = calculatorInstance.CalculateAge(new DateTime(1988, 04, 11));
            Console.WriteLine(age);
        }

        //Person

        [TestMethod]
        public void PersonTests()
        {
            Person person = new Person("Michael", "Pabody", new DateTime(2000, 01, 31));

            Console.WriteLine(person.FirstName + " " + person.LastName);
            Console.WriteLine(person.FullName);

            Console.WriteLine(person.Age);

            //Why black constructors can be unhelpful, missing data
            Person jake = new Person(); // this is relating to the empty constructor and you can add more if you want... it forces how you take in the data
            jake.FirstName = "Jacob";
            jake.DateOfBirth = new DateTime(1991, 05, 04);
            Console.WriteLine(jake.FullName); //would only show Jacob, b/c no LastName
            Console.WriteLine(jake.Age);

            person.LastName = "Torr"; //changes LastName to "Torr" at this point in the Test Method.
            Console.WriteLine(person.FullName); // Michael Torr, instead of Michael Pabody

            // Single Statement instance of new'ing up a person
            // There are times that single statement/line will be a lot easier 
            Person andrew = new Person()
            {
                FirstName = "Andrew",
                LastName = "Torr",
                DateOfBirth = new DateTime(1950, 12, 25)
            };

            //Asserting with a test that these two are equal
            Assert.AreEqual("Jacob", jake.FirstName);
            //Asserting that these are not equal 
            //Assert.AreNotEqual("Jacob", jake.FirstName);

        }

        //Within in the scope of the namespace, but outside of a method
        Person _person = new Person("Luke", "Skywalker", new DateTime(2000, 01, 31));


        [TestMethod]
        public void PersonTransportTest()
        {
            _person.Transport = new Vehicle("X-Wing", "Starship", 1000, VehicleType.Plane);
            Console.WriteLine($"{_person.FullName} drives a {_person.Transport.Make} {_person.Transport.Model}");

            _person.Transport.Make = "T16 Skyhopper";
            Console.WriteLine($"{_person.FullName} drives a {_person.Transport.Make}");

            Person blank = new Person();
            Console.WriteLine($"FullName: {blank.FullName}");

            Console.WriteLine($"Unset class: {blank.Transport}");
            Console.WriteLine($"Unset struct: {blank.DateOfBirth}");
            Console.WriteLine($"Age: {blank.Age}");
        }
    }
}
