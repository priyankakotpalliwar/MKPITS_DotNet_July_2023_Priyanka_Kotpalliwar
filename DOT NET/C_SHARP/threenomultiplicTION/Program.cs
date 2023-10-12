using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threenomultiplicTION
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2,eq1,eq2, num3;
            Console.WriteLine("enter num1");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2");
            num2=Convert.ToInt32(Console.ReadLine());
            eq1 = num1 * num2;
            Console.WriteLine("enter num 3");
            num3= Convert.ToInt32(Console.ReadLine());

            eq2 = eq1 * num3;
            Console.WriteLine("the multiplication is" + eq2);
            Console.ReadLine();
        }
    }
}
