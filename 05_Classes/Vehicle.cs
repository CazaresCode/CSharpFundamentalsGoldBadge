using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public enum VehicleType { Car, Truck, Van, Motocycle, Plane, Boat, Scooter}
    public class Vehicle
    {
        public Vehicle(string make, string model, double mileage, VehicleType typeOfVehicle )
        {
            Make = make;
            Model = model;
            Mileage = mileage;
            TypeOfVehicle = typeOfVehicle;
        }

        public Vehicle() { } //another constructor, with no parameters

        //1 Access Modifier 
        //2 Type - type the property holds
        //3 Name
        //4 Getters and setters

        //1      2     3      4
        public string Make { get; set; }
        public string Model { get; set; }
        public double Mileage { get; set; }
        public VehicleType TypeOfVehicle { get; set; }

        public bool IsRunning { get; private set;  }

        public void TurnOn()
        {
            IsRunning = true;
            Console.WriteLine("You turned on the vehicle");
        }

        public void TurnOff()
        {
            IsRunning = false;
            Console.WriteLine("You turned off the vehicle");
        }

        public bool RightIndicator { get; private set; }
        public bool LeftIndicator { get; private set; }

        public void IndicateRight() //no parameters
        {
            RightIndicator = true;  //RightIndicator is the property name
            LeftIndicator = false; 
        }
        public void IndicateLeft()
        {
            LeftIndicator = true;
            RightIndicator = false;
        }

        public void TurnOnHazards()
        {
            LeftIndicator = true;
            RightIndicator = true;
        }

        public void TurnOffHazards()
        {
            LeftIndicator = false;
            RightIndicator = false;
            //LeftIndicator.TurnOn
        }

        //Challenge 
        //make Indicator it's own custom class
        //properties including IsFlashing
        //method for TurnOn() and TurnOff()
        // - methods would set value of IsFlashing

        //custom class called Indicator instead of bool, like Vehicle 
    }

    public class Indicator
    {
        public bool isFlashing { get; private set; } 

        public void TurnOn()
        {
            isFlashing = true;
        }

        public void TurnOff()
        {
            isFlashing = false;
        }
    }
}
