using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program5_InstanceVariable
{
    class Program
    {
        int engMarks;
        int phyMarks;
        int mathsMarks;
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.engMarks = 90;
            obj.mathsMarks = 82;
            obj.phyMarks = 94;

            Program obj1 = new Program();
            obj1.engMarks = 78;
            obj1.mathsMarks = 92;
            obj1.phyMarks = 89;

            Console.WriteLine("Marks for first object are: {0},{1},{2}", obj.engMarks, obj.mathsMarks, obj.phyMarks);

            Console.WriteLine("Marks for second object are: {0},{1},{2}", obj1.engMarks, obj1.mathsMarks, obj1.phyMarks);

            Console.ReadLine();
        }
    }
}
