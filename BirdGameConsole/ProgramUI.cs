using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GeneralGamingMethods
{
    public class ProgramUI
    {
        public void Run()
        {
            //ProgramUI ui = new ProgramUI();
            //ui.Run();
        }

        public string [] ReadTheFile()
        {
            string text = File.ReadAllText(@"C:\Users\alexa\Desktop\ElevenFiftyProjects\GoldBadge\w1d2\CSharpFundamentals\BirdGameConsole\Bird.txt");
            
            string[] birds = text.Split(',');

            //foreach (var b in birds) //commented out b/c it was a method test to check to see if it works. But you'll need to run in the public void Run() above, calling the class and running the method. 
            //{
            //    return b;
            //}
            return birds;
        }

        //public int RunGameSequence()
        //{
        //    //create a switch case


        //}


        //run methods 
        // Put a foreach loop
        //return gamesmethod
    }
}
