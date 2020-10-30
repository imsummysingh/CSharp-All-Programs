using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program135_HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> myhash1 = new HashSet<string>();

            myhash1.Add("C");
            myhash1.Add("C++");
            myhash1.Add("C#");
            myhash1.Add("Python");
            myhash1.Add("Java");

            Console.WriteLine("Element of MyHash1:");

            foreach(var i in myhash1)
            {
                Console.WriteLine(i);
            }

            HashSet<int> myhash2 = new HashSet<int>()
            {
                10,100,1000,10000,100000
            };

            Console.WriteLine("Element of MyHash2:");

            foreach (var i in myhash2)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
