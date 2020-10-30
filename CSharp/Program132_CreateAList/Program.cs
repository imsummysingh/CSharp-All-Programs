using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program132_CreateAList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> my_list = new List<int>();

            my_list.Add(1);
            my_list.Add(10);
            my_list.Add(100);
            my_list.Add(1000);
            my_list.Add(10000);

            Console.WriteLine("The element in list are:");
            foreach(int i in my_list)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();

        }
    }
}
