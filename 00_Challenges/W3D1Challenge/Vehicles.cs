using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges.W3D1Challenge
{
    public class Vehicles
    {

        public class Sedan : IVehicles
        {
            public Sedan(string make, string model, string color)
            {
                Make = make;
                Model = model;
                Color = color;
            }

            public string Make { get; }
            public string Model { get; }
            public string Color { get; }
            public VehicleType TypeOfVehicle => VehicleType.Sedans;
            public bool IsRunning { get; private set; }
            public string Start()
            {
                IsRunning = true;
                return "You started the vehicle.";
            }

            public string TurnOff()
            {
                IsRunning = false;
                return "You turned off the vehicle.";
            }

            public bool IsBeingDriven { get; private set; }
            public string Drive()
            {
                IsBeingDriven = true;
                return "You are driving the vehicle.";
            }
        }

        public class SUV : IVehicles
        {
            public SUV(string make, string model, string color)
            {
                Make = make;
                Model = model;
                Color = color;
            }

            public string Make { get; }
            public string Model { get; }
            public string Color { get; }
            public VehicleType TypeOfVehicle => VehicleType.SUV;
            public bool IsRunning { get; private set; }
            public string Start()
            {
                IsRunning = true;
                return "You started the vehicle.";
            }

            public string TurnOff()
            {
                IsRunning = false;
                return "You turned off the vehicle.";
            }

            public bool IsBeingDriven { get; private set; }
            public string Drive()
            {
                IsBeingDriven = true;
                return "You are driving the vehicle.";
            }
        }

        public class Motorcycle : IVehicles
        {
            public Motorcycle(string make, string model, string color)
            {
                Make = make;
                Model = model;
                Color = color;
            }

            public string Make { get; }
            public string Model { get; }
            public string Color { get; }
            public VehicleType TypeOfVehicle => VehicleType.Motorcycle;
            public bool IsRunning { get; private set; }
            public string Start()
            {
                IsRunning = true;
                return "You started the vehicle.";
            }

            public string TurnOff()
            {
                IsRunning = false;
                return "You turned off the vehicle.";
            }

            public bool IsBeingDriven { get; private set; }
            public string Drive()
            {
                IsBeingDriven = true;
                return "You are driving the vehicle.";
            }
        }
    }
}
