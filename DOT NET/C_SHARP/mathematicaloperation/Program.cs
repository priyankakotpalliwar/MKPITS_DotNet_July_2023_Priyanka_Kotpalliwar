using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathematicaloperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2,result=0;
            int choice;
            Console.WriteLine("enter your choice 1-Addition.\r\n2-Substraction.\r\n3-Multiplication.\r\n4-Division.\r\n5-Exit.\r\n");
            choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num1");
            num1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2");
            num2= Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    break;
                    case 2:
                    result = num2 - num1;
                    break;
                    case 3:
                    result = num1 * num2;
                    break;
                    case 4:
                    result = num1 / num2;
                    break;
                    case 5:
                    Console.WriteLine("Exit");
                    break;
                default:
                    Console.WriteLine("not in work");
                    break;
                    
            }
            Console.WriteLine("result is" + result);
            Console.ReadKey();
        }
    }
}
