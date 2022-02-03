using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class m_bike : product
     {
         private int _weight;

        public override void cost()
        {
            Console.WriteLine("Cost");
        }

        public override void quantity()
        {
            Console.WriteLine("Quantity");
        }

        public int Weight { get => _weight; set => _weight = value; }

        public override void Print()
        {
            Console.WriteLine("This is mountain bike");
        }
    }
}

