using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Program124_ForegroundThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread th = new Thread(mythread);
            th.Start();
            Console.WriteLine("Main Thread Ends!!");
            Console.ReadLine();
        }
        static void mythread()
        {
            for(int c = 0; c <= 3; c++)
            {
                Console.WriteLine("My Thread in Progress!! ");
                Thread.Sleep(3000);
            }
            Console.WriteLine("My Thread Ends!!");
        }
    }
}
