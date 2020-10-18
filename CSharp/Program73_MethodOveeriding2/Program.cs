using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program73_MethodOveeriding2
{
    //using virtual and overriding
    class baseClass
    {
        public virtual void show()
        {
            Console.WriteLine("Base Class");
        }
    }
    class derived: baseClass
    {
        public override void show()
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
