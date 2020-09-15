using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program39_ConstructorOverloading
{
    class GFG
    {
        private int length, height;
        private double width;

        public GFG()
        {
            Console.WriteLine("Default Constructor");
        }
        public GFG(int l,double w):this()
        {
            Console.WriteLine("Paramateriezed constructor with 2 parameter");
            length = l;
            width = w;
        }
        public GFG(int l, int h, double w) : this(l,w)
        {
            Console.WriteLine("Parameterixed constructoor with 3 parameter");
            height = h;
        }
        public double volume()
        {
            return (length * height * width);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GFG obj = new GFG(1,2,3);
            Console.WriteLine(obj.volume());
            Console.ReadLine();
        }
    }
}
