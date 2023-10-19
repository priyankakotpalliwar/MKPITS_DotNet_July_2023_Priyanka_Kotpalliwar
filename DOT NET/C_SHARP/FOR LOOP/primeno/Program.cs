using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter number");
            num=Convert.ToInt32(Console.ReadLine());
            
            
                 if(num%2==0)
                {
                    Console.WriteLine("it  is a prime ");
                }
                else
                {
                    Console.WriteLine("not a prime no.");
                }
            
            Console.ReadKey();
        }
    }
}
