using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program09_ReferenceObjectType
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring String
            string a = "Geek";
            int x = 20;

            a += "for";
            a = a + "Geeks";

            Console.WriteLine(a);
            //Console.ReadLine();

            object obj;
            obj = 20;
            Console.WriteLine(obj);
            //Console.ReadLine();

            Console.WriteLine(obj.GetType());
            Console.WriteLine(a.GetType());
            Console.WriteLine(x.GetType());
            Console.ReadLine();
        }
    }
}
