﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passbyvalue
{
    internal class Program
    {
     static void display(int num)
        {
            num = 20;
            Console.WriteLine("num inside method" + num);//20

        }
        static void Main(string[] args)
        {
            int num = 10;
            display(num);
            Console.WriteLine("num after  passing main" + num);//10
            Console.ReadKey();
        }
    }
}
