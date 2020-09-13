using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program27_GetAndSet
{
    class student
    {
        private string name = "summy";
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
    class Program
    {        
        static void Main(string[] args)
        {
            student s = new student();
            //s.Name = "Summy Singh";

            Console.WriteLine("The name is : {0}", s.Name);
            Console.ReadLine();
        }
    }
}
