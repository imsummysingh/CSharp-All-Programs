using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


//creation of thread using static method
namespace Program127_CreationOfThread1
{
    public class ExThread
    {
        //static method for thread A
        public static void thread1()
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }

        //static method for thread B
        public static void thread2()
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Thread a = new Thread(ExThread.thread1);
            Thread b = new Thread(ExThread.thread2);
            a.Start();
            b.Start();
            Console.ReadLine();
        }
    }
}
