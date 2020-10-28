using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program107_CreateStringUsingConcatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello";
            string s2 = " World";
            string s3 = " I am";
            string s4 = " Corona";

            string str = s1 + s2 + s3 + s4;
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
