using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program111_Tuple1
{    
    class Program
    {
        static void Main(string[] args)
        {
            //creating tuple using constructor
            Tuple<string> my_tuple = new Tuple<string>("GeeksforGeeks");

            Tuple<string, string, int> my_tuple1 = new Tuple<string, string, int>("Summy", "Singh", 10);

            //creating tuple using create method

            var my_tuple2 = Tuple.Create("GeeksforGeeks");

            var my_tuple3 = Tuple.Create(1, 2, 3, 4, 5);

            var my_tuple4 = Tuple.Create(10, "Summy", 86, "DXC");

            Console.WriteLine("Element of tuple 3 is: " + my_tuple3.Item1);

            Console.WriteLine("Element of tuple 4 is: {0}, {1}, {2}, {3}", my_tuple4.Item1,my_tuple4.Item2,my_tuple4.Item3,my_tuple4.Item4);

            Console.ReadLine();

        }
    }
}
