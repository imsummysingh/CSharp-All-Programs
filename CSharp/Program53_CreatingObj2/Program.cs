using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//creating an array of objects
namespace Program53_CreatingObj2
{
    class Circle
    {
        public int radius;

        public Circle()
        {
            radius = 0;
        }

        //method to set value for radius
        public void setValue(int r)
        {
            radius = r;
        }

        //method to calculate value of area
        public double Area()
        {
            return (double)3.14 * radius * radius;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle[] circleArray = new Circle[2];

            //initialize the object
            circleArray[0] = new Circle();
            circleArray[1] = new Circle();

            //to set value of the radius
            circleArray[0].setValue(2);
            circleArray[1].setValue(4);

            for(int i = 0; i < circleArray.Length; i++)
            {
                Console.WriteLine("Area of circle with radius : " + (i + 1));
                Console.WriteLine(" is " + circleArray[i].Area() + "\n");
            }

            Console.ReadLine();
        }
    }
}
