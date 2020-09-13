using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program23_ParamKeyword2
{
    class Program
    {
        public void result(params object[] array)
        {
            for(int i =0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        static void Main(string[] args)
        {
            Program obj = new Program();

            obj.result("Summy", "Singh", 10);

            Console.ReadLine();
        }
    }
}
