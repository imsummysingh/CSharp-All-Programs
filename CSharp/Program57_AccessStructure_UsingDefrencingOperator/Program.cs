using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program57_AccessStructure_UsingDefrencingOperator
{
    struct Employee
    {
        public int Eid
        {
            get;
            set;
        }
        public double Esalary
        {
            get;
            set;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                Employee E1;
                Employee* ptr = &E1;

                (*ptr).Eid = 1;
                (*ptr).Esalary = 987.6;
                Console.WriteLine("Details of Employee");
                Console.WriteLine("Employee Id: {0} & Employee Salary: {1}", (*ptr).Eid, (*ptr).Esalary);
                Console.ReadLine();
            }
        }
    }
}
