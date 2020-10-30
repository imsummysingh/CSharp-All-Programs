using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Program126_CreationOfThread
{
    //creation of thread of using non-static method

    public class ExThread
    {
        //non-static method
        public void mythread1()
        {
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("First Thread");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //creating obbject of exthread class
            ExThread th = new ExThread();

            //creating thread using thread class
            Thread tr = new Thread(new ThreadStart(th.mythread1));
            tr.Start();

            Console.ReadLine();
        }
    }
}
