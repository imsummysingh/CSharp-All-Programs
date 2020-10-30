using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program120_Interface
{
    interface inter
    {
        void display();
    }
    class Program : inter
    {
        public void display()
        {
            Console.WriteLine("Calling the method as for interface");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.display();
            Console.ReadLine();
        }
    }
}
