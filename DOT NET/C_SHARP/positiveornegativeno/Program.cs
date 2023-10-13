using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace positiveornegativeno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter the number");
            num=Convert.ToInt32(Console.ReadLine());    
            if(num >0)
            {
                Console.WriteLine("number is positive");

                
            }
            else if(num == 0) 
            {
                Console.WriteLine("number is 0");

            }
            else
            {
                Console.WriteLine("number is negative");
            }
            Console.ReadKey();
        }
    }
}
