using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program87_Destructor
{
    class complex
    {
        int real, img;

        public complex()
        {
            real = 0;
            img = 0;
        }
        public void setValue(int r, int i)
        {
            real = r;
            img = i;
        }
        public void displayValue()
        {
            Console.WriteLine("Real = " + real);
            Console.WriteLine("Imaginary = " + img);
        }
        ~complex()
        {
            Console.WriteLine("Destructor Called");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            complex c = new complex();
            c.setValue(2, 3);
            c.displayValue();
            Console.ReadLine();
        }
    }
}
