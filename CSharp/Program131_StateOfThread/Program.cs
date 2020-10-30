using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Program131_StateOfThread
{
    public class MyThread
    {
        public void thread()
        {
            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine("My Thread");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyThread obj = new MyThread();
            Thread tr1 = new Thread(new ThreadStart(obj.thread));

            Console.WriteLine("Thread State: {0}", tr1.ThreadState);

            tr1.Start();
            Console.WriteLine("Thread State: {0}", tr1.ThreadState);

            tr1.Suspend();
            Console.WriteLine("Thread State: {0}", tr1.ThreadState);

            tr1.Resume();
            Console.WriteLine("Thread State: {0}", tr1.ThreadState);

            Console.ReadLine();
        }
    }
}
