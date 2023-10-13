using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equaltoornot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("enter the num1");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the num2");
            num2=Convert.ToInt32(Console.ReadLine());
            if(num1==num2)
            {
                Console.WriteLine("the number are equal");
            }
            else
            {
                Console.WriteLine("number are not equal");
            }
            Console.ReadKey();
        }
    }
}
