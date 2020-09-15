using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program45_this2
{
    //using this() to invoke the constructor in same class
    class Geeks
    {
        //this() to call the constructor in the constructor
        public Geeks() : this("geeks")
        {
            Console.WriteLine("Non - Paramter constructor");
        }
        public Geeks(string Name)
        {
            Console.WriteLine("Paramter Constructer called");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Geeks obj = new Geeks();
            Console.ReadLine();
        }
    }
}
