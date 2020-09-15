using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program38_PrivateConstructor
{
    public class Geeks
    {
        //private constrtuctor
        private Geeks()
        {

        }
        //static field
        public static int count_geeks;

        //static method
        public static int geeks_count()
        {
            return ++count_geeks;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //this is not accesible because of private constructor and static method
            //Geeks obj = new Geeks();

            Geeks.count_geeks = 10;
            Console.WriteLine(Geeks.count_geeks);
            Geeks.geeks_count();

            Console.WriteLine(Geeks.count_geeks);
            Geeks.geeks_count();
            Console.WriteLine(Geeks.count_geeks);
            Console.WriteLine(Geeks.geeks_count());
            Console.ReadLine();
        }
    }
}
