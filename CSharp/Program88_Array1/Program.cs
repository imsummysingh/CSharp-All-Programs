using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program88_Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray;
            intArray = new int[5];
            intArray[0] = 10;
            intArray[1] = 20;
            intArray[2] = 30;
            intArray[3] = 40;
            intArray[4] = 50;

            Console.WriteLine("For loop");
            for(int i=0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }

            Console.WriteLine("For each loop");
            foreach(int i in intArray)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("While Loop");
            int j = 0;
            while (j < intArray.Length)
            {
                Console.WriteLine(intArray[j]);
                j++;
            }

            Console.WriteLine("Do-While Loop");
            int k = 0;
            do
            {
                Console.WriteLine(intArray[k]);
                k++;
            }
            while (k < intArray.Length);

            Console.ReadLine();
        }
    }
}
