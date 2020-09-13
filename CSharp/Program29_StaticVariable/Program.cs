using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program29_StaticVariable
{
    class vehicle
    {
        public static string Car_Name = "Alto K10";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Vehicle Name is : {0}", vehicle.Car_Name);
            Console.ReadLine();
        }
    }
}
