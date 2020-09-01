using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program7_PointerType
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                int n = 10;

                //store variable n add
                //locaion in pointer p
                int* p = &n;
                Console.WriteLine("Value :{0}", n);
                Console.WriteLine("Address :{0}", (int)&n);
                Console.WriteLine("Address :{0}", (int)p);
                Console.WriteLine("Value :{0}", (int)&p);
                Console.ReadLine();
            }
        }
    }
}
