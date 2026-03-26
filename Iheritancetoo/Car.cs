using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iheritancetoo
{
    class Car : Vehicle
    {
        public override void Describe()
        {
            Console.WriteLine("This is a car. Name: " + Name + ", Speed: " + Speed);
        }
    }
}
