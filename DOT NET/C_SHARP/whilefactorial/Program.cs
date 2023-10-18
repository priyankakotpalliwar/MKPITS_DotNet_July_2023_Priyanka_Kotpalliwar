using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whilefactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fact = 1;
            int num;
            Console.WriteLine("enter number");
            num=Convert.ToInt32(Console.ReadLine());
            while(num> 0)
            {
                fact=fact*num;
                num--;
            }
            Console.WriteLine("factorial of number is {1}", num, fact);
            Console.ReadKey();
        }
    }
}
