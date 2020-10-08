using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program66_MethodParameter_RefParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            string val = "Dog";

            //pass as a reference parameter
            CompareValue(ref val);

            //display the given value
            Console.WriteLine(val);
            Console.ReadLine();
        }
        static void CompareValue(ref string val1)
        {
            //compare the value
            if (val1 == "Dog")
            {
                Console.WriteLine("Matched");
            }

            //assigning new value
            val1 = "cat";
        }
    }
}
