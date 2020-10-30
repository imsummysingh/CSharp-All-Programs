using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program116_MultiDimensionalIndexer1
{
    class Program
    {
        public Program() { }

        public int this[int i1, int i2]
        {
            get
            {
                return (i1+i2);
            }

            //no set accesssor used
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            for(int i = 0; i <= 2; i++)
            {
                for(int j = 1; j <= 3; j++)
                {
                    Console.Write(p[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
