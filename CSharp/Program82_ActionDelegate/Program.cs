using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program82_ActionDelegate
{
    class Program
    {
        public static void myfun(int p, int q)
        {
            Console.WriteLine(p - q);
        }
        static void Main(string[] args)
        {
            Action<int, int> val = myfun;
            val(10, 5);

            Console.ReadLine();
        }
    }
}
