using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Program134_SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList my_slist = new SortedList();

            my_slist.Add(1, "Summy");
            my_slist.Add(5, "Sunny");
            my_slist.Add(3, "Ranjeet");
            my_slist.Add(2, "Gupta");
            my_slist.Add(4, "Mani");

            foreach(DictionaryEntry pair in my_slist)
            {
                Console.WriteLine("Key: {0} & Value: {1}",pair.Key,pair.Value);
            }

            Console.WriteLine();

            SortedList my_slist2 = new SortedList()
            {
                {1,"A" },
                {5,"E" },
                {4,"D" },
                {3,"C"},
                {2,"B" }
            };

            foreach (DictionaryEntry pair in my_slist2)
            {
                Console.WriteLine("Key: {0} & Value: {1}", pair.Key, pair.Value);
            }

            Console.ReadLine();
        }
    }
}
