using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayclone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {2,3,5,8,9};
            int[] arr2 = new int[arr.Length];
           Array.Copy(arr, arr2, 3);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("arr2   "+arr2[i]);
            }
            Console.ReadKey();
        }
    }
}
