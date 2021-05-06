using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces.Fruit
{
    // Naming convention for interfaces begins with: I___
    public interface IFruit
    {
        string Name { get; }

        bool IsPeeled { get; }
        //Method in interfaces
        // Can only set the return type, name, and parameters
        string Peel();

    }
}
