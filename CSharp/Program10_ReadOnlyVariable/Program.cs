using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program10_ReadOnlyVariable
{
    class Program
    {
        readonly int k;
        Program()
        {
            k = 10;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();


            Console.WriteLine(obj.k);
            Console.ReadLine();

        }
    }
}
