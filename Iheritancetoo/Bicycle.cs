using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Iheritancetoo
{
    class Bicycle : Vehicle
    {
        public override void Describe()
        {
            Console.WriteLine("This is a Bicycle. Name: " + Name + ", Speed: " + Speed);
        }
    }
}
