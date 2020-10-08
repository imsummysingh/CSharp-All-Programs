using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program56_AccessStructure_UsingArrowMethod
{
    struct Student
    {
        public int rollno;
        public double marks;

        public Student(int r, double m)
        {
            rollno = r;
            marks = m;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //unsafe so as to use pointers
            unsafe
            {
                Student s1 = new Student(1, 95.0);
                Student s2 = new Student(2, 79.5);

                //declaring two student pointer and initializing them with addresses
                Student* s1_ptr = &s1;
                Student* s2_ptr = &s2;

                //using arrow operator
                Console.WriteLine("Details os Student1");
                Console.WriteLine("Roll No: {0} & Marks: {1}", s1_ptr->rollno, s1_ptr->marks);
                Console.WriteLine("Roll No: {0} & Marks: {1}", s2_ptr->rollno, s2_ptr->marks);
                Console.ReadLine();
            }
        }
    }
}
