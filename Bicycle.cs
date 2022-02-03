using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Bicycle : product
    {
        public override void cost()
        {
            Console.WriteLine("Cost");
        }

        public override void quantity()
        {
            Console.WriteLine("Quantity");
        }
    }
}
