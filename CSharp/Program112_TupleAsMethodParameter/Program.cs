using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program112_TupleAsMethodParameter
{
    class Program
    {
        static void Main(string[] args)
        {

            var mytuple = Tuple.Create("Summy", 10);
            printTuple(mytuple);
            Console.ReadLine();

        }
        static void printTuple(Tuple<string,int>mytuple)
        {
            Console.WriteLine("Element: " + mytuple.Item1);
            Console.WriteLine("Element: " + mytuple.Item2);
        }
    }
}
