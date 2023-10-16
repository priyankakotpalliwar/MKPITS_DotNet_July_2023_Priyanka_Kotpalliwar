using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberstoinwords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("enter the month  which you wanna know the days \n 1)january\n 2)feburary\n3)march\n4)april\n5)may\n6)june\n7)july\n8)august\n9)september\n10)octuber\n11)november\n12)december\n"
                );
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {

                Console.WriteLine(" january has 30 days ");
            }
            else if (choice == 2)
            {
                Console.WriteLine("feburary has 28 days");

            }
            else if (choice == 3)
            {
                Console.WriteLine("march has 31 days");

            }
            else if (choice == 4)
            {
                Console.WriteLine("april has 30 days");

            }
            else if (choice == 5)
            {
                Console.WriteLine("may has 31 days ");

            }
            else if (choice == 6)
            {
                Console.WriteLine("june has 30 days");

            }
            else if (choice == 7)
            {
                Console.WriteLine("july has 30  days");
            }
            else if (choice == 8)
            {
                Console.WriteLine("august has 31 days");

            }
            else if (choice == 9)
            {
                Console.WriteLine("september has 30 days");

            }
            else if (choice == 10)
            {
                Console.WriteLine("octuber has 31 days");

            }
            else if (choice == 11)
            {
                Console.WriteLine("november has 30 days");

            }
            else if (choice == 12)
            { Console.WriteLine(" december has 31 days"); }
            else
            {
                Console.WriteLine("exit");
            }
            Console.ReadKey();




        }
    }
}
