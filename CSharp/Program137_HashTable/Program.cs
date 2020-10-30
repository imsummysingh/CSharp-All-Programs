using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Program137_HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable my_hash = new Hashtable();
            my_hash.Add("A1", "Hello");
            my_hash.Add("A2", "World");
            my_hash.Add("A3", "I am Corona");

            Console.WriteLine("Hashtable Elemet: ");

            foreach(DictionaryEntry kv in my_hash)
            {
                Console.WriteLine("Key: {0} & Value: {1}", kv.Key, kv.Value);
            }

            Console.WriteLine();

            Hashtable my_hash1 = new Hashtable()
            {
                {1,"Summy" },{2,"Sunny"},{3,"Ranjeet"},{4,"Gupta"}
            };

            Console.WriteLine("Hashtable Elemet: ");

            foreach (DictionaryEntry kv in my_hash1)
            {
                Console.WriteLine("Key: {0} & Value: {1}", kv.Key, kv.Value);
            }

            Console.ReadLine();
        }
    }
}
