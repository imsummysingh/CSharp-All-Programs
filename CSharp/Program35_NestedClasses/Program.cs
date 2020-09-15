using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program35_NestedClasses
{
    public class Outer_Class
    {
        public void method1()
        {
            Console.WriteLine("The outer class method1");
        }

        public class Inner_Class
        {
            public void method2()
            {
                Console.WriteLine("The inner class method2");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Outer_Class obj1 = new Outer_Class();
            obj1.method1();

            Outer_Class.Inner_Class obj2 = new Outer_Class.Inner_Class();
            obj2.method2();

            Console.ReadLine();
        }
    }
}
