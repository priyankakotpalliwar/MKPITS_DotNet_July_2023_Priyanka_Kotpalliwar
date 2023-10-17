using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designationinswitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string designation;
            int bonus=0;
            Console.WriteLine("enter the designation");
            designation = Console.ReadLine();
            switch (designation)
            {
                case "manager":
                    bonus=10000;
                    break;
                case "clerk":
                    bonus = 5000;
                    break;
                case "peon":
                    bonus = 2000;
                    break;
                default:
                    bonus = 0;
                    break;


            }
            Console.WriteLine("designation - {0} and bonus is{1} ",designation, bonus);
            Console.ReadKey();
        }

    }
}
