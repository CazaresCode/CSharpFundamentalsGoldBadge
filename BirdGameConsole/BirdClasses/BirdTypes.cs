using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdGameConsole.birdClasses
{
    public class Bird : IBirdTypes
    {
        public string Name => "Bird";
        public int Points => 10;
    }

    public class CrestedIbis : IBirdTypes
    {
        public string Name => "CrestedIbis";
        public int Points => 100;
    }

    public class GreatKiskudee : IBirdTypes
    {
        public string Name => "GreatKiskudee";
        public int Points => 300;
    }
    public class RedCrossbill : IBirdTypes
    {
        public string Name => "RedCrossbill";
        public int Points => 500;
    }

    public class RedneckedPhalarope : IBirdTypes
    {
        public string Name => "Red-neckedPhalarope";
        public int Points => 700;
    }
    public class EveningGrosbeak : IBirdTypes
    {
        public string Name => "EveningGrosbeak";
        public int Points => 1000;
    }
    public class GreaterPrairieChicken : IBirdTypes
    {
        public string Name => "GreaterPrairieChicken";
        public int Points => 2000;
    }
    public class IcelandGull : IBirdTypes
    {
        public string Name => "IcelandGull";
        public int Points => 3000;
    }
    public class OrangeBelliedParrot : IBirdTypes
    {
        public string Name => "Orange-belliedParrot";
        public int Points => 5000;
    }

}




}
