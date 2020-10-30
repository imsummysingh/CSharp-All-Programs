using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Program130_Deadlock
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter into Deadlock");
                Thread.CurrentThread.Join();

                //the following statement will never execute
                Console.WriteLine("This statement will never execute");
            }
            catch(ThreadInterruptedException e)
            {
                e.ToString();
            }
            Console.ReadLine();
        }
    }
}
