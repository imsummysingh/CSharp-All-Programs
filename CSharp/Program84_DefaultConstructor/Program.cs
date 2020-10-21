using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program84_DefaultConstructor
{
    class Program
    {
        int a, b;

        public Program()
        {
            a = 10;
            b = 4;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.a);
            Console.WriteLine(p.b);

            Console.WriteLine("Result: " + (p.a * p.b));
            Console.ReadLine();
        }
    }
}
