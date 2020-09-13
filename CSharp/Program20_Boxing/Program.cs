using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program20_Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;

            //boxing
            object obj = num;

            //value of num is now changed
            num = 20;

            Console.WriteLine("The value of value type num is : {0}", num);

            Console.WriteLine("The value of reference type num is : {0}", obj);

            Console.ReadLine();

        }
    }
}
