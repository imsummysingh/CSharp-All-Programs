using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program03_RunTimeInitialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Please Enter Your Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your Name and Age is {0},{1}", name, age);
            Console.ReadLine();
        }
    }
}
