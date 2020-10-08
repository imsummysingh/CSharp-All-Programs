using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program61_Method_WithParameter_WithReturnValue
{
    class Program
    {
        static int factorial(int n)
        {
            int f = 1;
            for(int i = 1; i <= n; i++)
            {
                f = f * i;
            }
            return f;
        }
        static void Main(string[] args)
        {
            int n = 5;
            //factorial(n);
            Console.WriteLine("The factorial is: " + factorial(n));
            Console.ReadLine();
        }
    }
}
