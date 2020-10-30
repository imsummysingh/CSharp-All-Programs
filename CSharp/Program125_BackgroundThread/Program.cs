using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Program125_BackgroundThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread th = new Thread(mythread);
            th.Name = "MyThread";
            th.Start();
            //is background is a property which allows threads to run in background
            th.IsBackground = true;
            Console.WriteLine("Main Thread Ends!!!");
            Console.ReadLine();
        }
        static void mythread()
        {
            Console.WriteLine("In Progress thread is: {0}", Thread.CurrentThread.Name);
            Thread.Sleep(2000);
            Console.WriteLine("Completed Thread is: {0}", Thread.CurrentThread.Name);
        }
    }
}
