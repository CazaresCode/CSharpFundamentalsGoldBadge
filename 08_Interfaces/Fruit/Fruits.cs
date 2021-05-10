using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces.Fruit
{
    public class Banana : IFruit
    {
        //Constructor
        public Banana() { }
        public Banana(bool isPeeled)
        {
            IsPeeled = isPeeled;
        }

        // Properties
        public string Name
        {
            get
            {
                return "Banana";
            }
        }

        public bool IsPeeled { get; private set; } // you have to create a class method to set it to a true or false value

        // Class method
        public string Peel()
        {
            IsPeeled = true;
            return "You peeled the banana!";
        }
    }

    public class Orange : IFruit
    {
        //Constructors
        public Orange() { }
        public Orange(bool isPeeled)
        {
            IsPeeled = isPeeled;
        }
        public string Name
        {
            get
            {
                return "Orange";
            }
        }
        public bool IsPeeled { get; private set; }
        // Use the same interface method but bodies can be different as long as the return type matches
        public string Peel()
        {
            if (IsPeeled)
            {
                return "It's already Peel.";
            }
            else
            {
                IsPeeled = true; // if the bool was false, then we make it true here and then tell them "You peeled the orange."
                return "You peeled the orange.";
            }
        }
        // Classes that use interfaces can still have unique properties and methods.
        public string Squueze()
        {
            return "You squeeze the orange, and juice comes out.";
        }
    }

    public class Grape : IFruit
    {
        public string Name
        {
            get
            {
                return "Grape";
            }
        }

        // Hardsetting property as false. Hard-code
        public bool IsPeeled { get; } = false;
        public string Peel()
        {
            return "Who peels grapes?";
        }
    }

    //Make an Apple Class inheriting from IFruit - Challenege

    public class Apple : IFruit
    {

        // Lamba or 'phat arror'


        public string Name => "Apple";

        public bool IsPeeled { get; private set; }
        public string Peel()
        {
            if (IsPeeled)
            {
                return "Ready for pies";
            }
            else
            {
                IsPeeled = true;
                return "You peeled the apple.";
            }

        }
    }
}
