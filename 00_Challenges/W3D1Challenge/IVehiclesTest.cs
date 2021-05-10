using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static _00_Challenges.W3D1Challenge.Vehicles;

namespace _00_Challenges.W3D1Challenge
{
    [TestClass]
    public class IVehiclesTest
    {
        [TestMethod]
        public void SedanTests()
        {

            Sedan carOne = new Sedan("Mazda", "Mazda3", "Blue");

            var output = carOne.Start();
            Console.WriteLine(output);

        }
    }
}
