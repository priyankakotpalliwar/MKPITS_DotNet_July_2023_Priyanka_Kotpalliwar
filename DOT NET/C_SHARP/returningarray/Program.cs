using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace returningarray
{
    internal class Program
    {
        static int[] returnarray()
        {
            int[] num = { 2, 4, 6, 7, 8 };
            return num;

        }
        static void Main(string[] args)
            
        
        {
            int[] res = returnarray();
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }
            int[] res2 = returnarray();
            for (int i = 0;i < res2.Length; i++)
            {
                Console.WriteLine(res2[i]);
            }
           
            Console.ReadKey();
        }

    }
}
