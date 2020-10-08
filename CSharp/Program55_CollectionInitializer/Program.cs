using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Program55_CollectionInitializer
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList my_list = new SortedList()
            {
                {"b.09",234 },
                {"b.11",395 },
                {"b.01",876 },
                {"b.90",100 },
                {"b.87",987 }
            };
            foreach(DictionaryEntry pair in my_list)
            {
                Console.WriteLine("{0} and {1}", pair.Key, pair.Value);
            }
            Console.ReadLine();
        }
    }
}
