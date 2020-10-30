using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Program128_MainThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Main Thread");

            Thread t1 = new Thread(ChildThread);
            Thread t2 = new Thread(ChildThread);
            t1.Start();
            t2.Start();
            Console.ReadLine();
        }
        public static void ChildThread()
        {
            Console.WriteLine("This is Child Thread");
        }
    }
}
