﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("enter  the number");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
               
            }
            for(int i = 0;i < 10;i++) {
                Console.Write(arr1[i]+"\t");
            }

            Console.ReadKey();

        }
    }
}
