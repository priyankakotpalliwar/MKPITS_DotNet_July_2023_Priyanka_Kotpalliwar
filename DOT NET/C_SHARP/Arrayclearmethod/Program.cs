using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayclearmethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 9, 4, 8 ,5,55,67,88,99};
            Array.Clear(arr, 0,arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
