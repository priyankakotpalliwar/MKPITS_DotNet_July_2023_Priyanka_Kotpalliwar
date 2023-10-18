using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileaverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1=0,num2=0,num3=0,num4=0,num5=0,num6=0,num7=0,num8=0,num9=0,num10=0;
            float avg=0;
            float sum=0;
            Console.WriteLine("enter number 1");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 2");
            num2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 3");
            num3=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 4");
            num4=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 5");
            num5=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 6");
           num6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 7");
            num7=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 8");
            num8 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 9");
            num9=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 10");
            num10=Convert.ToInt32(Console.ReadLine());
            while(num1 <= 10 &&  num2 <= 10 && num3 <= 10 && num4 <= 10 && num5 <= 10 && num6 <= 10 && num7 <= 10 && num8 <= 10 && num9 <= 10 && num10 <= 10)
            {
                sum=sum+num1+num2+num3+num4+num5+num6+num7+num8+num9+num10;
                avg=sum/10.0f;

                    ;
            }
            Console.WriteLine("sum is{0} avg is{1}", sum, avg);
            Console.ReadKey();
        }
    }
}
