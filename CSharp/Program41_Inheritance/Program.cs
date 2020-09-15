using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program41_Inheritance
{
    class GFG
    {
        public string name;
        public string subject;

        public void readers(string name, string subject)
        {
            this.name = name;
            this.subject = subject;
            Console.WriteLine("Name : {0}", name);
            Console.WriteLine("Subject : {0}", subject);
        }
    }
    class Geeks : GFG
    {
        public Geeks()
        {
            Console.WriteLine("Child element");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Geeks g = new Geeks();
            g.readers("Summy", "CSE");
            Console.ReadLine();
        }
    }
}
