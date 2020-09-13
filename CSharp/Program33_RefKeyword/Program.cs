using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program33_RefKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            Console.WriteLine("The value of a is : {0}", a);
            Console.WriteLine("The value of b is : {0}", b);

            Console.WriteLine();

            //call addValue method by value
            addValue(a);

            //display modified value of a
            Console.WriteLine("Value of a after addition: {0}", a);

            //call substract method by ref
            substractValue(ref b);

            //display modified value of b
            Console.WriteLine("Value of b after addition: {0}", b);

            Console.WriteLine();

            Console.WriteLine("The value of a is : {0}", a);
            Console.WriteLine("The value of b is : {0}", b);

            Console.ReadLine();
        }

        public static void addValue(int a)
        {
            a += 10;
        }

        public static void substractValue(ref int b)
        {
            b -= 5;
        }
    }
}
