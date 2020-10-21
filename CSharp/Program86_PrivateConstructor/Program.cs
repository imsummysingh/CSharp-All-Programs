using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program86_PrivateConstructor
{
    class Geeks
    {
        public static string name;
        public static int num;

        private Geeks()
        {
            Console.WriteLine("Welcome to Private Constructor");
        }
        public Geeks(string a, int b)
        {
            name = a;
            num = b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Geeks g = new Geeks("Ankita", 2);
            Console.WriteLine(Geeks.name + ", " + Geeks.num);
            Console.ReadLine();
        }
    }
}
