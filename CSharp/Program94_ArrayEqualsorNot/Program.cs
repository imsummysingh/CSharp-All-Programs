using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program94_ArrayEqualsorNot
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = new string[4] { "sun", "mon", "tues", "thurs" };

            string[] arr2 = new string[4] { "sun", "mon", "tues", "thurs" };

            Console.WriteLine(arr1.Equals(arr2));

            string[] arr3 = new string[4];
            arr3 = arr1;

            Console.WriteLine(arr2.Equals(arr3));

            Console.WriteLine(arr3.Equals(arr1));

            Console.ReadLine();
        }
    }
}
