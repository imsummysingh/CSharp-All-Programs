using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program99_DynamicArray
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myarray = new List<int>();

            myarray.Add(123);
            myarray.Add(1);
            myarray.Add(2);
            myarray.Add(78);
            myarray.Add(67);

            Console.WriteLine("Before Sorting: ");
            foreach(var i in myarray)
            {
                Console.WriteLine(i);
            }

            myarray.Sort();

            Console.WriteLine("After Sorting: ");
            foreach(var i in myarray)
                {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
