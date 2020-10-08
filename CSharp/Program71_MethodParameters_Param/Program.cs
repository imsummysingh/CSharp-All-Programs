using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program71_MethodParameters_Param
{
    class Program
    {
        public static int mulval(params int[] num)
        {
            int res = 1;
            foreach(int j in num)
            {
                res *= j;

            }
            return res;
        }
        static void Main(string[] args)
        {
            int x = mulval(1, 2, 3, 4, 5);
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
