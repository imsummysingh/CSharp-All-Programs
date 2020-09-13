using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program06_ConstantVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            const int x = 10;
            //error throw of "const require value at the decalartion"
            //const int y;

            Console.WriteLine("X : " + x);
            Console.ReadLine();
        }
    }
}
