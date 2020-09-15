using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program43_AbstractClass
{
    //abstract class
    abstract class Shape
    {
        public abstract int area();
    }

    class Square : Shape
    {
        private int side;
        public Square(int x = 0)
        {
            side = x;
        }
        public override int area()
        {
            Console.Write("The Area of Square is: ");
            return (side * side);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape sh = new Square(4);
            double result = sh.area();
            Console.WriteLine("{0}", result);
            Console.ReadLine();
        }
    }
}
