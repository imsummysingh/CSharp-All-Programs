using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program31_StaticConstructor
{
    class G1
    {
        static G1()
        {
            Console.WriteLine("Example of static constructor");
        }
        public G1(int j)
        {
            Console.WriteLine("Instance Constructor " + j);
        }

        public string G1_Details(string name, string branch)
        {
            return "Name: " + name + "Branch: " + branch;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            //here both the static and instance constructor will be called
            G1 obj = new G1(1);

            Console.WriteLine(obj.G1_Details("Summy", "CSE"));

            //here only instance constructor will be called
            G1 obj1 = new G1(2);
            Console.WriteLine(obj.G1_Details("Sunny", "CSE"));

            Console.ReadLine();
        }
    }
}
