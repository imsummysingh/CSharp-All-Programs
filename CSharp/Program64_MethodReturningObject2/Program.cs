using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program64_MethodReturningObject2
{
    class Triangle
    {
        int Base;
        int Height;
        public Triangle(int b, int h)
        {
            Base = b;
            Height = h;
        }
        public int Area()
        {
            return ((Base * Height) / 2);
        }
        public void Display()
        {
            Console.WriteLine("Base of the triangle is : {0} And Height of the Triangle is : {1}", Base, Height);
        }
        public Triangle newdimension(int d)
        {
            return new Triangle(Base * d, Height * d);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle(2, 8);
            Console.WriteLine("Dimension of Triangle is: ");
            t1.Display();
            Console.WriteLine("Area of triangle is: {0}", t1.Area());
            Console.WriteLine();
            Console.WriteLine();

            Triangle t2 = t1.newdimension(2);
            Console.WriteLine("Dimension of Triangle is: ");
            t2.Display();
            Console.WriteLine("Area of triangle is: {0}", t2.Area());

            Console.ReadLine();
        }
    }
}
