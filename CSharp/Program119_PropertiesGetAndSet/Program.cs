using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program119_PropertiesGetAndSet
{
    public class student
    {
        private string name = "GeeksforGeeks";

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

            //calls set accessor and set the value to Summy
            s.Name = "Summy";

            Console.WriteLine("Name: {0}", s.Name);
            Console.ReadLine();

        }
    }
}
