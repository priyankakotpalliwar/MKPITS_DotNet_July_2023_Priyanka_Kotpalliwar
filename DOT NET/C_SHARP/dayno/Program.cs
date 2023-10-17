using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dayno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayno;
            Console.WriteLine("enter the day no. to know the day");
            dayno= Convert.ToInt32(Console.ReadLine());
            switch (dayno)
            {
                case 1:
                    Console.WriteLine("monday");
                    break;
                    case 2:
                    Console.WriteLine("tuesday");
                    break;
                    case 3:
                    Console.WriteLine("wednesday");
                    break;
                    case 4:
                    Console.WriteLine("Thursday");
                    break;
                    case 5:
                    Console.WriteLine("friday");
                    break;
                    case 6:
                    Console.WriteLine("saturday");
                    break;
                    case 7:
                    Console.WriteLine("sunday");
                    break;
                default:
                    Console.WriteLine("not a right fit");
                    break;
            }
            Console.ReadKey();
        }
    }
}
