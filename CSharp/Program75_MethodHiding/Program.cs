using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program75_MethodHiding
{
    public class My_family
    {
        public void member()
        {
            Console.WriteLine("Total no. of family member is 3");
        }
    }
    public class My_Member : My_family
    {
        //public new void member()
        //{
        //    Console.WriteLine("This is family");
        //}
        public void member()
        {
            //to call the hidden base class method
            //base.member();
            Console.WriteLine("This is family");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            My_Member obj = new My_Member();
            obj.member();

            //type casting to check the hidden methhod from base class
            //((My_family)obj).member();

            Console.ReadLine();
        }
    }
}
