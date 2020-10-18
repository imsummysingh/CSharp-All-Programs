using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program76_AnonymousMethod
{
    class Program
    {
        public delegate void petname(string pet);
        static void Main(string[] args)
        {
            petname p = delegate (string mypet)
            {
                Console.WriteLine("My Fav Pet is: {0}", mypet);
            };
           p("Fish");
            Console.ReadLine();
        }
    }
}
