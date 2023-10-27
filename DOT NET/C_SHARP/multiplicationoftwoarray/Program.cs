using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplicationoftwoarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = { { 2, 3 }, { 4, 5 } };
            int[,] arr2 = { { 6, 7 }, { 8, 9 } };
            int[,] arr3 = new int[2, 2];
            int r = 1;
            int c = 0;
            for(r = 0;r<2;r++)
            {
                for(c = 0;c<2;c++)
                {
                    arr3[r, c] = arr2[r, c] * arr1[r,c];
                }

            }
            for(r = 0; r<2;r++)
            {
                for (c = 0;c < 2;c++)
                {
                    Console.Write(arr3[r, c]+"\t");
                }
                Console.WriteLine();
               
            }
            Console.ReadKey();
        }
    }
}
