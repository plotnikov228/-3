using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal abstract class product 
    {
        abstract public void cost();

        abstract public void quantity();

        public virtual void Print()
        {
            Console.WriteLine("This is transport");
        }

    }
}
