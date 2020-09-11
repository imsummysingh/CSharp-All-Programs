using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program14_PublicModifier
{
    class Student
    {
        public int rollNo;
        public string name;

        public Student(int r, string n)
        {
            rollNo = r;
            name = n;
        }

        public int getRollNo()
        {
            return rollNo;
        }
        public string getName()
        {
            return name;
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Student obj = new Student(10,"summy");

            //displaying details using method

            Console.WriteLine("The RollNo is: {0}", obj.getRollNo());

            Console.WriteLine("The Name is: {0}", obj.getName());

            //displaying details using member
            Console.WriteLine("The RollNo is: {0}", obj.rollNo);

            Console.WriteLine("The Name is: {0}", obj.name);


            Console.ReadLine();
                        
        }
    }
}
