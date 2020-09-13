using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program24_ImplicitTypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;

            long l = i;

            float f = l;

            Console.WriteLine("The value of i is : {0}", i);
            Console.WriteLine("The value of l is : {0}", l);
            Console.WriteLine("The value of f is : {0}", f);
            Console.ReadLine();
        }
    }
}
