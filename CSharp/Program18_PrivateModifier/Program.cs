using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program18_PrivateModifier
{
    class parent
    {
        private int value;

        public void setValue(int x)
        {
            value = x;
        }

        public int getValue()
        {
            return value;
        }
    }

    class child: parent
    {
        public void showValue()
        {
            //inaccesible due to protection level
            //Console.WriteLine("The value is : {0}", value);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            parent obj = new parent();
            obj.setValue(10);
            //obj.getValue();
            Console.WriteLine("The value is : {0}", obj.getValue());
            Console.ReadLine();
        }
    }
}
