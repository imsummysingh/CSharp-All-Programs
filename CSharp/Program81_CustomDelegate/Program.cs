using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program81_CustomDelegate
{
    class Program
    {
        public delegate void my_delegate(int p, int q);
        public static void myfun(int p, int q)
        {
            Console.WriteLine(p - q);
        }
        static void Main(string[] args)
        {
            my_delegate obj = myfun;
            obj(10, 5);
            Console.ReadLine();
        }
    }
}
