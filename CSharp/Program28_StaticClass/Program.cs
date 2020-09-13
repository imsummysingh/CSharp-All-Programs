using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program28_StaticClass
{
    static class Tutorial
    {
        public static string Topic = "C SHarp Static Class";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The topic name is : {0}", Tutorial.Topic);
            Console.ReadLine();
        }
    }
}
