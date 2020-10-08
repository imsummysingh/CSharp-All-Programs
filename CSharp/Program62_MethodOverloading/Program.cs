using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program62_MethodOverloading
{
    class Program
    {
        public int add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        public int add(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }
        public double add(int a, double b)
        {
            double sum = a + b;
            return sum;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            int sum1 = obj.add(2, 3);
            int sum2 = obj.add(2, 3, 4);
            double sum3 = obj.add(2, 3.1);
            Console.WriteLine("Value of Method with 2 integer Paramter: " + sum1);
            Console.WriteLine("Value of Method with 3 integer Parameter: " + sum2);
            Console.WriteLine("Value of Method with 2 int and double parameters: " + sum3);
            Console.ReadLine();
        }
    }
}
