using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eligibletovote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("enter the age");
            age=Convert.ToInt32(Console.ReadLine());    
            if(age>=18)
            {
                Console.WriteLine("elieligible to vote");

            }
            else
            {
                Console.WriteLine("not eligible to vote");
            }
            Console.ReadKey();
        }
    }
}
