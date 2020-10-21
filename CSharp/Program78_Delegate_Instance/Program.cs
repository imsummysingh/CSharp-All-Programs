using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program78_Delegate_Instance
{
    class Program
    {
        public delegate void addnum(int a, int b);
        public delegate void subnum(int a, int b);

        public void sum(int a, int b)
        {
            Console.WriteLine("(100+40)={0}", a + b);
        }
        public void substract(int a, int b)
        {
            Console.WriteLine("(100-60)={0}", a - b);
        }
        static void Main(string[] args)
        {
            Program obj = new Program();

            addnum del_obj1 = new addnum(obj.sum);
            subnum del_obj2 = new subnum(obj.substract);

            del_obj1(100, 40);
            del_obj2(100, 60);

            //del_obj1.Invoke(100, 40);
            //del_obj2.Invoke(100, 60);

            Console.ReadLine();
        }
    }
}
