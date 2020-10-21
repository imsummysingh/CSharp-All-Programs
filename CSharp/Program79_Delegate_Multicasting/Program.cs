using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program79_Delegate_Multicasting
{
    class Program
    {
        public delegate void rectDelegate(double height, double width);
        
        public void area(double height, double width)
        {
            Console.WriteLine("Area is: {0}", (width * height));
        }

        public void perimeter(double height, double width)
        {
            Console.WriteLine("Perimeter is: {0}", 2 * (height + width));
        }
        static void Main(string[] args)
        {
            Program p = new Program();

            rectDelegate rectdel = new rectDelegate(p.area);

            rectdel += p.perimeter;

            rectdel.Invoke(2, 3);
            Console.WriteLine();

            rectdel.Invoke(3, 4);
            Console.ReadLine();
        }
    }
}
