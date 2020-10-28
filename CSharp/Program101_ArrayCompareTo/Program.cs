using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program101_ArrayCompareTo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 4, 3, 7, 9, 44, 2 };

            Array.Sort<int>(arr, new Comparison<int>((i1, i2) => i2.CompareTo(i1)));

            foreach(var i in arr)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
