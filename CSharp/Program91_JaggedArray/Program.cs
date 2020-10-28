using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program91_JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[2][];
            arr[0] = new int[5] { 1, 2, 3, 4, 5 };
            arr[1] = new int[4] { 1, 2, 3, 4 };

            int[][] arr1 =
            {
                new int [] {1,2,3,4,5},
                new int[] {1,2,3,4}
            };

            for (int i =0; i<arr.Length; i++)
            {
                Console.WriteLine("Element [" + i + "] Array: ");
                for(int j =0; j < arr[i].Length; j++)
                {
                    Console.WriteLine(arr[i][j] + " ");
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Another Array");

            for(int i = 0; i<arr1.Length; i++)
            {
                Console.WriteLine("Element [" + i + "] Array: ");
                for(int j = 0; j < arr1[i].Length; j++)
                {
                    Console.WriteLine(arr1[i][j] + " ");
                    Console.WriteLine();
                }
            }

            Console.ReadLine();
        }
    }
}
