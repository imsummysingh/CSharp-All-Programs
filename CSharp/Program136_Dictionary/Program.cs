using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program136_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(1, "Hello");
            dict.Add(2, "World");
            dict.Add(3, "I am Corona");

            foreach(KeyValuePair<int, string> kv in dict)
            {
                Console.WriteLine("Key: {0} & Value: {1}", kv.Key, kv.Value);
            }

            Console.WriteLine();

            Dictionary<string, string> dict2 = new Dictionary<string, string>()
            {
                {"a","A" },{"b","B"},{"c","C"},{"d","D"}
            };

            foreach(KeyValuePair<string,string> kv1 in dict2)
            {
                Console.WriteLine("Key: {0} & Value: {1}", kv1.Key, kv1.Value);
            }

            Console.ReadLine();
        }
    }
}
