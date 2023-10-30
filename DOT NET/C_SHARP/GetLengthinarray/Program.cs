using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetLengthinarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 4, 5, 7, 8 ,8,90,9999};
         int l=arr.GetLength(0);
            Console.WriteLine("length"+l);
            Console.ReadKey();
        }
        
    }
}
