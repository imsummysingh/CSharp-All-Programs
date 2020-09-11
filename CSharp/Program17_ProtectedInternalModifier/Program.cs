using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program17_ProtectedInternalModifier
{
    internal class X
    {
        protected int x;

        public X()
        {
            x = 10;
        }
    }

    internal class Y : X
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
            Y obj = new Y();

            Console.WriteLine("The value of X is: {0}", obj.getX());
            Console.ReadLine();
        }
    }
}
