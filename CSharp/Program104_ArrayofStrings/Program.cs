using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program104_ArrayofStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] str_arr = new string[3];

            str_arr[0] = "Summy";
            str_arr[1] = "Ranjeet";
            str_arr[2] = "Gupta";

            foreach(var i in str_arr)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
