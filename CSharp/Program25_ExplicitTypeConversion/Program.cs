using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program25_ExplicitTypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = 765.42;

            //explicit type casting

            int i = (int)d;

            Console.WriteLine("The value of double is : {0}", d);

            Console.WriteLine("The value of int is : {0}", i);

            Console.ReadLine();
        }
    }
}
