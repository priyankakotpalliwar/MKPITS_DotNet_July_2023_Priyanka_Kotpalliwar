using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passingparameterinarray
{
    internal class Program
    {
        static void acceptarray(int[]arr)
        {
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);  
                sum = sum + arr[i];
            }
            Console.WriteLine(sum);

        }
        static void Main(string[] args)
        {
            int[] num = { 2, 3, 4, };
            acceptarray(num);
            int[] num1 = {4,5,6};
            acceptarray(num1);
            Console.ReadKey();
        }
    }
}
