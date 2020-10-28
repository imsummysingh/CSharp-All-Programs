using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program110_StringBuilderAppend
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder s = new StringBuilder("Hello", 20);
            s.Append("Summy");
            s.AppendLine("Singh");
            s.Append("summy singh");
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
