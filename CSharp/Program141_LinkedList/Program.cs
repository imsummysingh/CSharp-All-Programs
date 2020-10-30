using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program141_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> my_list = new LinkedList<string>();

            my_list.AddLast("Summy");
            my_list.AddLast("Sunny");
            my_list.AddLast("Ranjo");
            my_list.AddLast("Gupta");
            my_list.AddLast("Mani");

            Console.WriteLine("The list of people:");

            foreach(string str in my_list)
            {
                Console.WriteLine(str);
            }
            Console.ReadLine();
        }
    }
}
