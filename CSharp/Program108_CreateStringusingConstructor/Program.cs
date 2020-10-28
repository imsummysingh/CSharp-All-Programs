using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program108_CreateStringusingConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chars = { 'S', 'U', 'M', 'M', 'Y' };

            string str1 = new string(chars);
            Console.WriteLine(str1);

            string str2 = new string('S', 10);
            Console.WriteLine(str2);

            Console.ReadLine();
        }
    }
}
