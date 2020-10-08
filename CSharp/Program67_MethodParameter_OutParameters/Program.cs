using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program67_MethodParameter_OutParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            AddNum(out num);

            Console.WriteLine("The sum of " + "the value is: {0}", num);
            Console.ReadLine();
        }
        public static void AddNum(out int num)
        {
            num = 40;
            num += num;
        }
    }
}
