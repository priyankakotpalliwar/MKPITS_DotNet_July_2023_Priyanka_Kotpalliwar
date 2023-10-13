using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelseifelse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2,num3;
            Console.WriteLine("enter the num1 ");
            num1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the num2");
            num2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the num3");
            num3= Convert.ToInt32(Console.ReadLine());
            if(num1>num2 && num1>num3)
            {
                Console.WriteLine("num 1 is grearer");
            }
            else if(num2>num3)
            {
                Console.WriteLine("num2 is greater");
            }
            else
            {
                Console.WriteLine("num3 is greater");
            }
            Console.ReadKey();
        }
    }
}
