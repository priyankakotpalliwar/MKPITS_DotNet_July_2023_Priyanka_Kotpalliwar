using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areaofgeometricexpersiion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int len, breadth,height;
            float radius;
            float result=0;
            int choice=0;
            Console.WriteLine("enter the choice to detect area of shape\n  1)circle\n 2)square\n 3)rectangle");
            choice=Convert.ToInt32(Console.ReadLine());
                             switch(choice)
            {
                case 1:
                    Console.WriteLine("enter radius");
                    radius = Convert.ToInt32(Console.ReadLine());
                    result = 3.14f *radius*radius;
                    break;
                    case 2:
                    Console.WriteLine("enter lenght");
                    len = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter breadth");
                    breadth = Convert.ToInt32(Console.ReadLine());
                    result = len * breadth;
                    break;
                    case 3:
                    Console.WriteLine("enter height");
                    height = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter breadth");
                    breadth = Convert.ToInt32(Console.ReadLine());
                    result= height * breadth;
                    break;
                default:
                    Console.WriteLine("not in data");
                    break;







            }
            Console.WriteLine(" area of given {0} is{1}", choice,result);
            Console.ReadKey();
        }
    }
}
