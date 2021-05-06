using _08_Interfaces.Fruit;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _08_Interfaces
{
    [TestClass]
    public class IFruitTests
    {
        [TestMethod]
        public void CallingInterfaceMethods()
        {
            IFruit banana = new Banana();
            Banana banana1 = new Banana();
            // Can't create an interface object
            //IFruit banana = new IFruit ();

            // var is like a wildcard argument 
            var output = banana.Peel();
            Console.WriteLine(output);

            Console.WriteLine("The banana is peeled: " + banana.IsPeeled);
            Assert.IsTrue(banana.IsPeeled);
        }

        [TestMethod]
        public void InterfacesInCollection()
        {
            Orange orange = new Orange();

            // Var allows different fruits using the IFruit interface to exist together
            var fruitSalad = new List<IFruit>
            {
                new Banana(),
                new Orange(),
                orange
            };
            // ORange exclusive methods still accessible outside of IFruit collection
            orange.Squueze();

            foreach (var fruit in fruitSalad)
            {
                Console.WriteLine(fruit.Name);
                Console.WriteLine(fruit.Peel());
                // NO longer accessible once in a collection
                // fruit.squeeze

                Assert.IsInstanceOfType(fruit, typeof(IFruit));
            }

            Assert.IsInstanceOfType(orange, typeof(Orange));
        }

        private string GetFruitName(IFruit fruit)
        {
            return $"This fruit is called {fruit.Name}";
        }

        [TestMethod]
        public void InterfaceInMethods()
        {
            var grape = new Grape();

            // Even though the method only takes IFruit, grape still qualities 
            string output = GetFruitName(grape);

            Console.WriteLine(output);
        }

        [TestMethod]
        public void TypeOfInstance()
        {
            var fruitSalad = new List<IFruit>
            {
                new Orange(true),
                new Orange(),
                new Grape(),
                new Orange(),
                new Banana(true),
                new Grape()
            };

            Console.WriteLine("Is the orange peeled?");
            foreach(var fruit in fruitSalad)
            {
                // Checking it's of type orange, casting it as orange
                // Pattern Matching
                if (fruit is Orange orange)
                {
                    if (orange.IsPeeled)
                    {
                        Console.WriteLine("It's a peeled orange.");
                        // Regain prange exlusive properties.
                        orange.Squueze();
                    }
                    else
                    {
                        Console.WriteLine("It's an orange.");
                    }
                }
                else if (fruit.GetType() == typeof(Grape))
                {
                    Console.WriteLine("It's a grape!");
                    //without pattern matching, cast is neceassry 
                    var grape = (Grape)fruit;
                    Console.WriteLine(grape.Peel());
                }
                else if (fruit.IsPeeled)
                {
                    Console.WriteLine("It is a peeled banana");
                }
                else
                {
                    Console.WriteLine("It's a banana");
                }
            }
        }
    }
}
