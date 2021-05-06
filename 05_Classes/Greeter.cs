using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Greeter
    {
        //1 Access Modifier
        //2 Return Type
        //3 Method Signature - includes the method Name and any parameters
        //4 Body of the method - code that get's executed when the method is called
        
        //example below
//        //  1      2                  3a                     3b
//        public void SomeMethod(int intParameter)
//        {
//            // 4
//        }
//        Access modifier
//        Return type(void if not returning anything)
//        Signature(a - Name, b - Parameters)
//        Body(where the actionable lines of code are written)



        public void SayHello(string name) //inside the () are called parameters
        {
            Console.WriteLine($"Hello {name}!");
        }

        public void SaySomething(string speech)
        {
            Console.WriteLine(speech);
        }

        public string GetRandomGreeting() //doesnt need parameters
        {
            Random randy = new Random();
            string[] greetings = new string[] { "Hello", "hi", "sup", "yo", "hey" };
            int randomNumber = randy.Next(0, greetings.Length); //however long is the stringArray... zero is min because zero if first, remember?
            string greeting = greetings[randomNumber];
            return greeting;
        }
    }
}
