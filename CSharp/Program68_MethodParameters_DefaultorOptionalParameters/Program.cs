using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program68_MethodParameters_DefaultorOptionalParameters
{
    class Program
    {
        //this method contains two regular parameter i.e ename and eid
        //and 2 optional parameterss i.e bgrp and dept

        static public void details(string ename, int eid, string bgrp="A+", string dept = "Review-Team")
        {
            Console.WriteLine("Emp Name: {0}", ename);
            Console.WriteLine("Emp Id: {0}", eid);
            Console.WriteLine("Blood Group: {0}", bgrp);
            Console.WriteLine("Department: {0}", dept);
            Console.WriteLine();
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            details("Summy", 106722);
            details("ABC", 234, "B-");
            details("CDE", 123, "c-", "software developer");
            Console.ReadLine();
        }
    }
}
