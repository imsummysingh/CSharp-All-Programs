using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program98_ObjectArray
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] arr = new object[6];
            arr[0] = 1;
            arr[1] = "summy";
            arr[2] = 1.67;
            arr[3] = 'a';
            arr[4] = null;
            arr[5] = new object();

            foreach(var i in arr)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
