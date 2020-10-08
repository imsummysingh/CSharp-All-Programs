using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program60_Method_WithParamters_WithoutReturnValue
{
    class Program
    {
        static void perimeter(int p)
        {
            Console.WriteLine("Perimeter of the square is : " + 4 * p);
        }
        static void Main(string[] args)
        {
            int p = 5;
            perimeter(p);
            Console.ReadLine();
        }
    }
}
