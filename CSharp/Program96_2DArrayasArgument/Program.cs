﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program96_2DArrayasArgument
{
    class Program
    {
        static int temp = 0;
        static void transpose(int[,] arr)
        {
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = i; j < arr.GetLength(1); j++)
                {
                    temp = arr[i, j];
                    arr[i, j] = arr[j, i];
                    arr[j, i] = temp;
                }
            }
        }
        static void displayResult(int[,] arr)
        {
            Console.WriteLine("Matrix after Transpose");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                   
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[,] arr = new int[4,4]
            {
                {1,2,3,4 },
                {5,6,7,8 },
                {9,10,11,12 },
                {13,14,15,16 }
            };

            Console.WriteLine("Matrix before Transpose");

            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            transpose(arr);

            displayResult(arr);

            Console.ReadLine();
        }
    }
}
