using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program63_MethodReturningObject
{
    class Example
    {
        private string str;

        public void setdata(string s)
        {
            str = s;
        }
        public void display()
        {
            Console.WriteLine("String is: " + str);
        }
        //method that return object
        public Example astr(Example ex)
        {
            //creating object of example
            Example obj = new Example();

            //adding the value of passes an object in the current object and adding the sum in another project
            obj.str = str + ex.str;
            return obj;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Example o1 = new Example();
            Example o2 = new Example();
            o1.setdata("Geeks");
            o2.setdata("For Geeks");
            Example o3 = o1.astr(o2);
            o1.display();
            o2.display();
            o3.display();
            Console.ReadLine();
        }
    }
}
