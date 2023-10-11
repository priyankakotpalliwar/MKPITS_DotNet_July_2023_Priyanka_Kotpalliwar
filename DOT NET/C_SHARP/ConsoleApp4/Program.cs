using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, division;
            Console.WriteLine("enter the num1");
            num1=Convert.ToInt32(Console.ReadLine());       
            Console.WriteLine("enter the num 2");
            num2=Convert.ToInt32(Console.ReadLine());
            division = num1 / num2;
            Console.WriteLine("the division of the num"+ division);
            Console.ReadLine();
        }
    }
}
