using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program32_TypeOf
{
    class Program
    {
        static Type a = typeof(double);
        static void Main(string[] args)
        {
            //display the type of a
            Console.WriteLine(a);

            //display the value type
            Console.WriteLine(typeof(int));
            Console.WriteLine(typeof(char));

            //display the class type
            Console.WriteLine(typeof(Array));

            //display the reference type
            Console.WriteLine(typeof(int[]));

            Console.ReadLine();
            
        }
    }
}
