using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program93_ArrayEqualorNot
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[,]
            {
                {1,2 },
                {3,4 }
            };

            Console.WriteLine(arr.Equals(arr));
            Console.ReadLine();
        }
    }
}
