using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Program122_SingleThreadedModel
{
   public class Geek
    {
        public static void method1()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Method is: {0}", i);
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
    }
    class Program
    {
        static void Main(string[] args)
        {
            Geek.method1();
            Geek.method2();
            Console.ReadLine();
        }
        
    }
}
