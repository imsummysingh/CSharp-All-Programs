using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program19_PrivateProtectedModifier
{
    class parent
    {

        //private protected was introduce in 7.2
        private protected int value;

        public void setValue(int x)
        {
            value = x;
        }

        public int getValue()
        {
            return value;
        }
    }

    class child : parent
    {
        public void showValue()
        {
            Console.WriteLine("The value is : {0}",+value);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            child obj = new child();
            obj.setValue(10);
            Console.WriteLine("The value is :", +obj.getValue());
            Console.ReadLine();
        }
    }
}
