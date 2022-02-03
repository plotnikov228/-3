using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Scooter scooter = new Scooter();
            m_bike m_Bike = new m_bike();
            Bicycle bicycle = new Bicycle();

            product[] product = new product[10];

            product[0] = scooter;
            product[1] = m_Bike;
            product[2] = bicycle;

            m_Bike.Weight = 5;

            Console.WriteLine((product[1] as m_bike).Weight);

            if (product[0] is Scooter)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);   
            }

            Console.ReadKey();
        }
    }
}
