using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program97_ImplicitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var author_name = new[]
            {
                "summy",
                "Ranjeet",
                "Vicky",
                "Mani",
                "Shubham"
            };

            Console.WriteLine("List of Authors: ");
            for(int i = 0; i < author_name.Length; i++)
            {
                Console.WriteLine(author_name[i]);
            }

            Console.ReadLine();
        }
    }
}
