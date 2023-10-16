using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbertoweekendday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("enter the number to know the week day"
                );
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {

                Console.WriteLine(" monday ");
            }
            else if (choice == 2)
            {
                Console.WriteLine("tuesday");

            }
            else if (choice == 3)
            {
                Console.WriteLine("wednesday");

            }
            else if (choice == 4)
            {
                Console.WriteLine("thursday");

            }
            else if (choice == 5)
            {
                Console.WriteLine("friday ");

            }
            else if (choice == 6)
            {
                Console.WriteLine("saturday");

            }
            else if (choice == 7)
            {
                Console.WriteLine("sunday");
            }
            else
            {
                Console.WriteLine("exit");
            }
            Console.ReadKey();



        }
    }
}
