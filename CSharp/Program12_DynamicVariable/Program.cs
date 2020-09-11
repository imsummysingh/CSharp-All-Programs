using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program12_DynamicVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic a = 10;
            dynamic b = "summy";
            dynamic c = 1.0;
            dynamic d = true;

            Console.WriteLine("The value of a is : {0}", a.GetType());
            Console.WriteLine("The value of b is : {0}", b.GetType());
            Console.WriteLine("The value of c is : {0}", c.GetType());
            Console.WriteLine("The value of d is : {0}", d.GetType());

            Console.ReadLine();
        }
    }
}
