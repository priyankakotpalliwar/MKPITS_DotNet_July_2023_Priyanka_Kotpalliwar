using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            int sum = 0;
            foreach (int val in arr)
            {
                sum=sum+val;
            }Console.WriteLine("sum of array" + sum);
            Console.ReadKey();
            
        }
    }
}
