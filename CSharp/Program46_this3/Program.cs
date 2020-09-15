using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program46_this3
{
    //this keyword to invoke current class method
    class Test
    {
        public void display()
        {
            this.show();
            Console.WriteLine("Inside Display Function");
        }

        public void show()
        {
            Console.WriteLine("Inside Show Function");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test t1 = new Test();
            t1.display();
            Console.ReadLine();
        }
    }
}
