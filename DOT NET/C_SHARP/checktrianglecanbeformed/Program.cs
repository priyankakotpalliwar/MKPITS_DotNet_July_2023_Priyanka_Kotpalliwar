using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checktrianglecanbeformed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ang1, ang2,ang3,sum;
            Console.WriteLine("enter angle 1");
            ang1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter angle 2");
            ang2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter angle 3");
            ang3 = Convert.ToInt32(Console.ReadLine());
            sum=ang1+ ang2+ang3;
            if(sum == 180)
            {
                Console.WriteLine(" triangle can be formed");
            }
            else
            {
                Console.WriteLine("the triangle is not valid");
            }
            Console.ReadKey();
           
        }
    }
}
