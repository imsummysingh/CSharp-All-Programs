using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program04_LocalVariable
{
    class Program
    {
        public void StudentAge()
        {
            //local variable
            int age = 0;
            age = age + 10;
            Console.WriteLine("The Age is: " + age);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.StudentAge();
        }
    }
}
