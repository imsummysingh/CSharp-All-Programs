using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2_CompileTimeInitialization
{
    class Program
    {
        int y;
        static void Main(string[] args)
        {
            int x = 30;
            Console.WriteLine("X : " + x);

            Program gfg = new Program();

            Console.WriteLine("Value of Y: " + gfg.y);

            Console.ReadLine();
        }
    }
}
