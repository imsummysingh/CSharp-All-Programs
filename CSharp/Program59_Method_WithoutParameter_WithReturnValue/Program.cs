using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program59_Method_WithoutParameter_WithReturnValue
{
    class Program
    {
        static int sum()
        {
            int a, b;
            a = 10;
            b = 11;
            int add;
            add = a + b;
            return add;
        }
        static void Main(string[] args)
        {
            int result = sum();
            Console.WriteLine("The sum is: {0}", result);
            Console.ReadLine();
        }
    }
}
