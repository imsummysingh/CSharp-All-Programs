using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program42_Encapsulation
{
    public class DemoEncap
    {
        //private variable declared and these can only be accessed by public method of the class
        private string studentName;
        private int studentAge;

        //using get and set 
        public string Name
        {
            get
            {
                return studentName;
            }
            set
            {
                studentName = value;
            }
        }
        public int Age
        {
            get
            {
                return studentAge;
            }
            set
            {
                studentAge = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DemoEncap obj = new DemoEncap();

            obj.Name = "Summy";
            obj.Age = 24;
            Console.WriteLine(obj.Name);
            Console.WriteLine(obj.Age);
            Console.ReadLine();
        }
    }
}
