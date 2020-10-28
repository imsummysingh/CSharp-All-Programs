using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program105_ReadingStringfromUser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");

            String read_user = Console.ReadLine();

            Console.WriteLine("User Entered: " + read_user);

            Console.ReadLine();
        }
    }
}
