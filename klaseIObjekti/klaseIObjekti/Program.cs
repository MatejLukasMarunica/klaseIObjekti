using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klaseIObjekti
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Zrakoplov x380 = new Zrakoplov("Airbus", 2000, 6000);

            Console.WriteLine(x380.ToString());

            Zrakoplov C162 = new Zrakoplov("Skyscratcher", 75, 870);

            Console.WriteLine(C162.ToString());

            Zrakoplov PC21 = new Zrakoplov("Pilatus", 1200, 1333);

            Console.WriteLine(PC21.ToString());

            Console.ReadKey();
        }
    }
}
