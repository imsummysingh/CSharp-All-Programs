using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program21_UnBoxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;

            //boxing
            object obj = num;

            //unboxing
            int i = (int)obj;

            Console.WriteLine("The value of value type num is : {0}", num);
            Console.WriteLine("The value of reference type obj is : {0}", obj);
            Console.WriteLine("The value of unboxed type i is : {0}", i);

            Console.ReadLine();
        }
    }
}
