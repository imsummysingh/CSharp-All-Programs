using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program37_CopyConstructor
{
    class Geeks
    {
        private string name;
        private int age;
        public Geeks(Geeks s)
        {
            name = s.name;
            age = s.age;
        }

        public Geeks(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Details
        {
            get
            {
                return "Name :" + name + " and Age: " + age;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Geeks obj1 = new Geeks("Summy", 24);

            //copying the details
            Geeks obj2 = new Geeks(obj1);

            Console.WriteLine(obj2.Details);
            Console.ReadLine();
        }
    }
}
