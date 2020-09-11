using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program11_Var
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = "summy";
            var c = 1.0;
            var d = true;

            Console.WriteLine("Type of var a is : {0}",a.GetType());

            Console.WriteLine("Type of var b is : {0}", b.GetType());

            Console.WriteLine("Type of var c is : {0}", c.GetType());

            Console.WriteLine("Type of var d is : {0}", d.GetType());

            Console.ReadLine();

        }
    }
}
