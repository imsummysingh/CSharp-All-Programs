using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program30_StaticMethod
{
    class NPark
    {
        static public int i = 104;

        public static void total()
        {
            Console.WriteLine("The number of National Parks in india are : {0}", i);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NPark.total();
            Console.ReadLine();
        }
    }
}
