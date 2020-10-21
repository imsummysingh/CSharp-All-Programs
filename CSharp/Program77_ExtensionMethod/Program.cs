using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program77_ExtensionMethod
{
    static class NewMethodClass
    {
        public static void M4(this Geek g)
        {
            Console.WriteLine("M4");
        }
        public static void M5(this Geek g, string str)
        {
            Console.WriteLine(str);
        }
    }
    class Program
    {        
        static void Main(string[] args)
        {
            Geek g = new Geek();
            g.M1();
            g.M2();
            g.M3();
            g.M4();
            g.M5("M5");

            Console.ReadLine();
        }
    }
}
