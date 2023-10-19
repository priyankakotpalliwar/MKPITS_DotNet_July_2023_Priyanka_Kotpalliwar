using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumof5no
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //write a program to accept 5 no. print the sum of 5 no
            int num;
            int sum = 0;
            int counter;
            for(counter=10;counter>5;counter--)
            {


                Console.WriteLine("enter the number");
                num = Convert.ToInt32(Console.ReadLine());
                sum = sum + num;

            }

            Console.WriteLine("sum" + sum);

            Console.ReadKey();
            
        }
    }
}
