using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Program129_AccessMainThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread th = Thread.CurrentThread;

            if (th.Name == null)
            {
                Console.WriteLine("Main Thread does not exist");
            }
            else
            {
                Console.WriteLine("The name of main thread is : {0} ", th.Name);
            }
            Console.WriteLine();

            Console.WriteLine("The priority of main Thread is: {0}", th.Priority);

            th.Name = "Main Thread";
            Console.WriteLine();

            Console.WriteLine("The name of main thread is: {0}", th.Name);

            Console.ReadLine();
            
        }
    }
}
