using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program08_StaticVariable
{
    class Program
    {
        static double salary;
        static string name = "summy";
        static void Main(string[] args)
        {
            //Program.salary = 1000;
            //Console.WriteLine(Program.name + " Salary is : " + Program.salary);
            //Console.ReadLine();

            Program.salary = 10000;
            Program.salary = 20000;

            Console.WriteLine("The salary is : " + Program.salary);

            Program.salary = 30000;

            Console.WriteLine("The new salary is : " + Program.salary);
            Console.ReadLine();
        }
    }
}
