using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Program123_MutithreadingModel
{
    class Program
    {   
        public static void method1()
        {
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Method 1 is: {0}", i);
                if (i == 5)
                {
                    Thread.Sleep(6000);
                }
            }
        }

        public static void method2()
        {
            for(int j = 0; j <= 10; j++)
            {
                Console.WriteLine("Method 2 is: {0}", j);
            }
        }

        static void Main(string[] args)
        {
            Thread t1 = new Thread(method1);
            Thread t2 = new Thread(method2);
            t1.Start();
            t2.Start();

            Console.ReadLine();
        }
    }
}
