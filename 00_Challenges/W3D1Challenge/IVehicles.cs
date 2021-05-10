using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges.W3D1Challenge
{
    public enum VehicleType { Sedans, SUV, Motorcycle }
    public interface IVehicles
    {
        VehicleType TypeOfVehicle { get; }
        string Make { get; }
        string Model { get; }
        string Color { get; }
        bool IsRunning { get; }
        bool IsBeingDriven { get; }

        // method
        string Start();
        string TurnOff();
        string Drive();

        //public void Drive(){-insert body-}
        //public void Start(){-insert body-}
        //public void TurnOff(){-insert body-}
    }
}
