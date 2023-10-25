using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodwith3parameter
{
    internal class Program
    { static int Calculate(int num1, int num2, char op)
        {
            int res = 0;
            if (op == '+')
                res = num1 + num2;
            else if (op == '-')
                res = num1 - num2;
            else if (op == '*')
                res = num1 * num2;
            else
                Console.WriteLine("invalid operator");
            return res;
        }
        static void Main(string[] args)
        {
            int number1, number2;
            char oper;
            Console.WriteLine("enter number 1 ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 2 ");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter operator");
            oper=Convert.ToChar(Console.ReadLine());
            int result= Calculate(number1 , number2, oper); 
            Console.WriteLine("result"+ result);
            Console.ReadKey();
        }
    }
}
