using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program114_Indexer
{
    class IndexCreation
    {
        private string[] val = new string[3];

        public string this[int index]
        {
            get
            {
                return val[index];
            }
            set
            {
                val[index] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IndexCreation ic = new IndexCreation();
            ic[0] = "c";
            ic[1] = "cpp";
            ic[2] = "python";

            Console.WriteLine("Printing value stored in object as a arrays:");

            Console.WriteLine("{0}, {1}, {2}", ic[0], ic[1], ic[2]);
            Console.ReadLine();
        }
    }
}
