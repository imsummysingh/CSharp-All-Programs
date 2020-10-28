using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program89_Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weekdays;

            weekdays = new string[] { "sun", "mon", "tues", "wed", "thurs", "fri", "sat" };

            foreach(string day in weekdays)
            {
                Console.WriteLine(day);
            }
            Console.ReadLine();
        }
    }
}
