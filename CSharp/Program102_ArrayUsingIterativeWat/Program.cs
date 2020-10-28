using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program102_ArrayUsingIterativeWay
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 9, 3, 7, 2, 9, 4, 8 };

            int temp;

            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            foreach(var i in arr)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
