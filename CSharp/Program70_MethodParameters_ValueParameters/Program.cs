using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program70_MethodParameters_ValueParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Summy";
            string s2 = "Singh";
            string res = addstr(s1, s2);
            Console.WriteLine(res);
            Console.ReadLine();
        }
        public static string addstr(string s1, string s2)
        {
            return s1 + s2;
        }
    }
}
