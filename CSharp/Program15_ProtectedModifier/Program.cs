using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program15_ProtectedModifier
{
    class X
    {
        protected int x;

        public X()
        {
            x = 10;
        }
    }

    class Y : X
    {
        public int getX()
        {
            return x;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            X obj1 = new X();
            Y obj2 = new Y();

            Console.WriteLine("The value of x is accessed by its child which is y");
            Console.WriteLine("The value of x is: {0}", obj2.getX());

            Console.ReadLine();
        }
    }
}
