using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program92_ArraYBinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[7] { 1, 3, 6, 2, 4, 8, 5 };

            Array.Sort(arr);

            Console.WriteLine("The element of array is sorted");
            //Console.WriteLine(arr);

            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }

            object s = 9;

            //calling method for binary search
            result(arr, s);

            object s1 = 4;
            result(arr, s1);

            Console.ReadLine();
        }

        static void result(int[] arr1, object k)
        {
            int res = Array.BinarySearch(arr1, k);

            if (res < 0)
            {
                Console.WriteLine("The element to search for "+ "({0}) is not found.",k);
            }
            else
            {
                Console.WriteLine("The element to search for " + "({0}) is found at index {1}", k,res);
            }
        }
    }
}
