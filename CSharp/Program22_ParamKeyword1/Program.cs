using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program22_ParamKeyword1
{
    class Program
    {
        public static int Add(params int[] ListNumbers)
        {
            int total = 0;

            foreach(int i in ListNumbers)
            {
                total += i;
            }
            return total;
        }
        static void Main(string[] args)
        {
            int y = Add(1, 2, 3, 4, 5);

            Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}
