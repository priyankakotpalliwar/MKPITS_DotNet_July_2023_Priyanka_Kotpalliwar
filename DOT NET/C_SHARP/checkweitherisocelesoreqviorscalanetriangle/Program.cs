using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkweitherisocelesoreqviorscalanetriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int side_a,side_b,side_c,side_d;
            Console.WriteLine("enter the side a");
            side_a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the side b");
            side_b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the side c");
            side_c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the side d");
            side_d= Convert.ToInt32(Console.ReadLine());
            if(side_a==side_b||side_b==side_c)
            {
                Console.WriteLine("it is a equilateral triangle");
            }
            else if(side_a==side_b||side_a==side_c||side_b==side_c)
            {
                Console.WriteLine("it is a isocelus triangle");
            }
            else
            {
                Console.WriteLine("it is scalene triangle");  
            }
            Console.ReadKey();

        }
    }
}
