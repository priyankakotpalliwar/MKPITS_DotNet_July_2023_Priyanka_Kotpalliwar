﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace outparameter
{
    internal class Program
    {
        static void calculate(int radius,
        out float area,out float circ)
        {
            area = 3.14f * radius * radius;
            circ = 2 * 3.14f * radius;
        }
        static void Main(string[] args)
        {
            int radius = 5;
            calculate( radius, out float area, out float circ);
            Console.WriteLine("area ="+area); Console.WriteLine("circumference " + circ);
            Console.ReadKey();
        }
    }
}
