using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program74_MethodOverriding3
{
    //use of base in method overriding
    public class web
    {
        string name = "GeeksforGeeks";

        public virtual void show()
        {
            Console.WriteLine("Webiste name: "+name);
        }
    }
    class stream: web
    {
        string s = "Computer Science";

        public override void show()
        {
            base.show();
            Console.WriteLine("About :" + s);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            stream E = new stream();
            E.show();
            Console.ReadLine();
        }
    }
}
