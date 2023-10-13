using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leapyearornot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("enter the year  you wanna check leap year");
            year = Convert.ToInt32(Console.ReadLine()); 
            //if((year %400)==0)
            //{
                //Console.WriteLine("{0} is a leap year" , year);

           // }
           // else if((year %100)==0)
           // {
             //   Console.WriteLine("is a  not leap year" ,year);
            //}
            if ((year % 4) == 0)
                Console.WriteLine("{0} is a leap year.\n",year);
            else
                Console.WriteLine("{0} is not a leap year.\n",year);
            Console.ReadKey();
        }
    }
}
