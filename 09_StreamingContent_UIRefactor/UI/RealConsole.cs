using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StreamingContent_UIRefactor.UI
{
    public class RealConsole : IConsole
    {
        public void Clear()
        {
            Console.Clear(); //doesnt need a return type because it has a void return type
        }

        public ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey(); // needs a return type
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public void Write(string s)
        {
            Console.Write(s);
        }

        public void WriteLine(string s)
        {
            Console.WriteLine(s);
        }

        public void WriteLine(object o)
        {
            Console.WriteLine(o);
        }

        public void WriteLine(DateTime d)
        {
            Console.WriteLine(d);
        }
    }
}
