using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program118_PropertiesReadOnly
{
    public class student
    {
        private static int cnt;

        public student()
        {
            cnt++;
        }
        public static int counter
        {
            get
            {
                return cnt;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student();
            student s2 = new student();
            student s3 = new student();

            Console.WriteLine("Total no. of student: {0}", student.counter);
            Console.ReadLine();
        }
    }
}
