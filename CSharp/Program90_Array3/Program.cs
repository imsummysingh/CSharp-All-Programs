using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program90_Array3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] intArray = new int[,]
            {
                {1,2 },
                {3,4},
                {5,6},
                {7,8},
                {9,10}
            };

            int[,] intArray_d = new int[5, 2]
            {
                {1,2 },
                {3,4},
                {5,6},
                {7,8},
                {9,10}
            };

            string[,] str = new string[4, 2]
            {
                {"one","two" },
                {"three","four" },
                {"five","six" },
                {"seven","eight" }
            };

            int[,,] intArray3D = new int[,,]
            {
                { {1,2,3 },
                {4,5,6 } },
                { {7,8,9 },
                {10,11,12 } }
            };
        }
    }
}
