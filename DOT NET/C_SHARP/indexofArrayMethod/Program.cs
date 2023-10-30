using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexofArrayMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 5, 8,19,99,90 };
            int l = Array.IndexOf(arr, 5);
            Console.WriteLine("INDEX has "+ l);
            Console.ReadKey();
            
        }
    }
}
