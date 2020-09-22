using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//creating refernce to existing object
namespace Program52_CreatingObj1
{
    class Triangle
    {
        public int side, altitude;
        public double Area()
        {
            return (double)0.5 * side * altitude;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle();

            //only  create a refernce of type triangle
            Triangle t2;
            t1.side = 3;
            t1.altitude = 4;
            Console.WriteLine("The area of triangle is : {0}", t1.Area());

            //assigning refernce to t1
            t2 = t1;

            //making chnages
            t2.side = 5;
            t2.altitude = 6;

            //displaying area of t1 with changes
            Console.WriteLine("After t2");
            Console.WriteLine("The area of triangle is : {0}", t1.Area());
            Console.ReadLine();
        }
    }
}
