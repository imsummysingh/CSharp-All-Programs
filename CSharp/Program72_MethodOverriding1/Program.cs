using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program72_MethodOverriding1
{

    //without using virtual or overiding
    class baseClass
    {
        public void show()
        {
            Console.WriteLine("Base Class");
        }
    }
    class derived: baseClass
    {
        //overriding
        new public void show()
        {
            Console.WriteLine("Derived Class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            baseClass objP = new baseClass();
            objP.show();

            derived objD = new derived();
            objD.show();

            objP = new derived();
            objP.show();

            Console.ReadLine();
        }
    }
}
