﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace additionoftwoarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = { { 1, 2 },{ 3,4 }};
            int[,] arr2 = { { 11, 22 }, { 33, 44 } };
            int[,] arr3 = new int[2, 2];
                for (int r = 0;r<2;r++)
            {
                for(int c = 0;c<2;c++)
                {
                    arr2[r,c]= arr1[r, c] + arr2[r,c];
                }
            }
                for(int r = 0; r<2;r++)
            {
                for(int c = 0; c<2;c++)
                {
                    Console.Write(arr2[r,c]+"\t");
                }
                Console.WriteLine();
            }
                
            Console.ReadKey();
        }
    }
}
