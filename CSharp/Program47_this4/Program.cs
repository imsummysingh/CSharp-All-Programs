using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program47_this4
{
    //using this keyword as method parameters
    class Program
    {
        int a, b;
        Program()
        {
            a = 10;
            b = 20;
        }
        //method that recieves 'this' keyword as parameter
        void display(Program obj)
        {
            Console.WriteLine("a = {0} and b = {1}", a, b);
        }

        //method that return current instance
        void get()
        {
            display(this);
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.get();
            Console.ReadLine();
        }
    }
}
