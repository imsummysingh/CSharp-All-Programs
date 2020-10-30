using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program115_MultiDimensionalIndexer
{
    class MultiDimensionalIndexer
    {
        int[,] data = new int[5, 5];

        public int this[int index1, int index2]
        {
            get
            {
                return data[index1, index2];
            }
            set
            {
                data[index1, index2] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MultiDimensionalIndexer ic = new MultiDimensionalIndexer();
            ic[0, 0] = 1;
            ic[0, 1] = 2;
            ic[0, 2] = 3;

            ic[1, 0] = 4;
            ic[1, 1] = 5;
            ic[1, 2] = 6;

            ic[2, 0] = 7;
            ic[2, 1] = 8;
            ic[2, 2] = 9;

            Console.WriteLine("{0}\t{1}\t{2}\n{3}\t{4}\t{5}\n{6}\t{7}\t{8}", ic[0, 0], ic[0, 1], ic[0, 2], ic[1, 0], ic[1, 1], ic[1, 2], ic[2, 0], ic[2, 1], ic[2, 2]);
            Console.ReadLine();
        }
    }
}
