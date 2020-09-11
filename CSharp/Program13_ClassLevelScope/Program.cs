using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program13_ClassLevelScope
{
    class Program
    {
        int a = 10;

        public void display()
        {
            Console.WriteLine("The value of A through class level scope is : {0}",a);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.display();
        }
    }
}
