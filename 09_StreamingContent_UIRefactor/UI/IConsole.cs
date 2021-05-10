using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StreamingContent_UIRefactor.UI
{
    public interface IConsole
    {
        //creating methods, no props
        void WriteLine(string s);
        void WriteLine(object o);
        void WriteLine(DateTime d); // Reference Types
        void Write(string s);
        string ReadLine(); //takes the info from the user, that's it.
        ConsoleKeyInfo ReadKey(); // Reference Types
        void Clear();
    }
}
