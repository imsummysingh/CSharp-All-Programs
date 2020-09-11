using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program16_InternalAccessModifier
{
    internal class complex
    {
        int real;
        int img;

        public void setData(int r, int i)
        {
            real = r;
            img = i;
        }

        public void displayData()
        {
            Console.WriteLine("Real = {0}", real);
            Console.WriteLine("Imaginary = {0}", img);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            complex obj = new complex();

            obj.setData(1, 2);
            obj.displayData();
            Console.ReadLine();
        }
    }
}
