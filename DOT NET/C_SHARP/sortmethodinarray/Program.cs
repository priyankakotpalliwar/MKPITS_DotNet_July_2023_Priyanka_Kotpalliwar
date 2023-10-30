using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortmethodinarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 9, 6, 2, 7,0 };
            Array.Sort(arr);
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
