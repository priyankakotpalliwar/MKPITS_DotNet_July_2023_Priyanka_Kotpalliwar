using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readdigitanddisplayinwords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            string character="a";
            Console.WriteLine("enter the num");
            num=Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    character = "one";
                    break;
                    case 2:
                    character = "two";
                    break;
                    case 3:
                    character = "three";
                    break;
                    case 4:
                    character = "four";
                    break;
                    case 5:
                    character = "five";
                    break;  
                    case 6:
                    character = "six";
                    break;
                    case 7:
                    character = "seven";
                    break;
                    case 8:
                    character = "eight ";
                    break;
                    case 9:
                    character = "nine";
                    break;
                    case 10:
                    character = "ten";
                    break;
                    case 11:
                    character = "eleven";
                    break;
                    case 12:
                    character = "twelve";
                    break;
                default:
                    Console.WriteLine("not assigned");
                    break;


            }
            Console.WriteLine("the num {0} in words is {1}",num,character);
            Console.ReadKey();
        }
    }
}
