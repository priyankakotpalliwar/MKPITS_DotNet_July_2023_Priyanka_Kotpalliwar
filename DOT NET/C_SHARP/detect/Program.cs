using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace detect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("enter the choice to know the month\n"
                );
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {

                Console.WriteLine(" january  ");
            }
            else if (choice == 2)
            {
                Console.WriteLine("feburary");

            }
            else if (choice == 3)
            {
                Console.WriteLine("march");

            }
            else if (choice == 4)
            {
                Console.WriteLine("april");

            }
            else if (choice == 5)
            {
                Console.WriteLine("may  ");

            }
            else if (choice == 6)
            {
                Console.WriteLine("june ");

            }
            else if (choice == 7)
            {
                Console.WriteLine("july ");
            }
            else if (choice == 8)
            {
                Console.WriteLine("august");

            }
            else if (choice == 9)
            {
                Console.WriteLine("september ");

            }
            else if (choice == 10)
            {
                Console.WriteLine("octuber ");

            }
            else if (choice == 11)
            {
                Console.WriteLine("november ");

            }
            else if (choice == 12)
            { Console.WriteLine(" december "); }
            else
            {
                Console.WriteLine("exit");
            }
            Console.ReadKey();




        }
    }
}
