using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program83_FuncDelegate
{
    class Program
    {
        public static int mymethod(int s, int d, int f, int g)
        {
            return s * d * f * g;
        }
        static void Main(string[] args)
        {
            Func<int,int,int,int,int> val = mymethod;
            Console.WriteLine(val(1, 2, 3, 4));

            Console.ReadLine();
        }
    }
}
