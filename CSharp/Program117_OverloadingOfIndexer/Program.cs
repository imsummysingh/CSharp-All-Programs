using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program117_OverloadingOfIndexer
{
    class Program
    {
        private string[] word = new string[2];

        public string this[int flag]
        {
            get
            {
                string temp = word[flag];
                return temp;
            }
            set
            {
                word[flag] = value;
            }
        }

        //overloaded indexer
        public string this[float flag]
        {
            get
            {
                string temp = word[1];
                return temp;
            }
            set
            {
                word[1] = value;
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p[0] = "Hello";
            p[1.0f] = " Geeks";

            Console.WriteLine(p[0] + p[1.0f]);
            Console.ReadLine();
        }
    }
}
