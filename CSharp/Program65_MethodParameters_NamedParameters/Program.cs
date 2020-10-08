using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program65_MethodParameters_NamedParameters
{
    class Program
    {
        public static void addstr(string s1, string s2, string s3)
        {
            string result = s1 + s2 + s3;
            Console.WriteLine("Result : {0}", result);
        }
        static void Main(string[] args)
        {
            //paramter without any order
            addstr(s1: "Hi ", s3: " summy", s2: "i am ");
            Console.ReadLine();
        }
    }
}
