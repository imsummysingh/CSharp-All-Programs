using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program40_CopyConstructorOverloading
{
    class GFG
    {
        public string p1, p2;
        public int p3, p4;

        //1st constructor
        public GFG(string x, string y)
        {
            p1 = x;
            p2 = y;
        }

        //copy of 1st constructor
        public GFG(GFG g)
        {
            p1 = g.p1;
            p2 = g.p2;
        }

        //2nd constructor
        public GFG(int a, int b)
        {
            p3 = a;
            p4 = b;
        }

        //copy of 2nd constrtuctor
        public GFG(GFG a, GFG b)
        {
            p3 = a.p3;
            p4 = b.p4;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            GFG g = new GFG("Hello", "World");

            //Here g details is copied to g1
            GFG g1 = new GFG(g);

            Console.WriteLine(g1.p1 + " to the " + g1.p2);
            Console.WriteLine();

            GFG G = new GFG(10, 20);
            GFG G1 = new GFG(G, G);
            Console.WriteLine("Values are : {0} & {1}", G1.p3, G1.p4);

            Console.ReadLine();
        }
    }
}
