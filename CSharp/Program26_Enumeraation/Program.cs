using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program26_Enumeraation
{
    enum month
    {
        jan,
        feb,
        march,
        april,
        may,
        june
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The value of Jan in Month is :" + (int)month.jan);
            Console.WriteLine("The value of March in Month is :" + (int)month.march);
            Console.WriteLine("The value of May in Month is :" + (int)month.may);
            Console.ReadLine();
        }
    }
}
