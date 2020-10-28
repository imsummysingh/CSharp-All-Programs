using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program100_ArraySort_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 3, 2, 7, 45, 9, 6 };

            //sort in ascending order
            Array.Sort(arr);

            //reverse array
            Array.Reverse(arr);

            foreach(var i in arr)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
