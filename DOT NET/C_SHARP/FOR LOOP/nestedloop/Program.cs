﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nestedloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
           for(int i=1;i<=3;i++)
            {
                for(int j=1;j<=3;j++)
                {
                    Console.Write(i+"\t");
                }
                Console.WriteLine();
            }
           Console.ReadKey();
        }

    }
}
