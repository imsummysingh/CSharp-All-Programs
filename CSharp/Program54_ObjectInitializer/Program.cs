using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program54_ObjectInitializer
{
    class Geek
    {
        public string author_name
        {
            get;
            set;
        }

        public int author_id
        {
            get;
            set;
        }

        public int total_article
        {
            get;
            set;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Geek obj = new Geek()
            {
                author_name = "summy",
                author_id = 10,
                total_article = 101
            };

            Console.WriteLine("Author Name: {0}", obj.author_name);
            Console.WriteLine("Author Id : {0}", obj.author_id);
            Console.WriteLine("Total Article: {0}", obj.total_article);
            Console.ReadLine();
        }
    }
}
