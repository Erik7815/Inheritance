using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iheritancetoo
{
    class Vehicle
    {
        public int Speed;
        public string Name;
        public virtual void Describe()
        {
            Console.WriteLine("This is a vehicle");
        }
    }
}
