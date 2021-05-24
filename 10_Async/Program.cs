using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Async
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to make a meal.");
            Console.ReadKey();

            Kitchen kitchen = new Kitchen(); // Creating a new instance so we can access the methods in this class.
            Potato potato = new Potato();

            // Synchronously
            potato.Peel();

            // Asynchonously  drop the fires.
            // Async so I can do other things.
            var fries = kitchen.FryPotatoesAsync(potato);

            // Synchronosuyly assemble a burger while fires are cooking. 
            var hamburger = kitchen.AssembleBurger();

            Console.WriteLine("Doing other stuff...");

            // We can't serve the meal until the fires are done due to the delay of 10 seconds!
            kitchen.ServeMeal(fries.Result, hamburger);

            Console.ReadKey();
        }
    }
}
