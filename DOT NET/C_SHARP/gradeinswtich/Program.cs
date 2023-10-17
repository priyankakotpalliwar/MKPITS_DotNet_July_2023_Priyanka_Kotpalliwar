using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradeinswtich
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string grade;
            Console.WriteLine("enter the grade");
            grade= Console.ReadLine();
            switch (grade)
            {
                case "E":
                case "e":
                    Console.WriteLine("Excellent");
                    break;
                case "V":
                case "v":
                    Console.WriteLine("very good");
                    break;
                case "G":
                case "g":

                    Console.WriteLine("Good");
                    break;
                case "A":
                case "a":
                    Console.WriteLine("average");
                    break;
                case "F":
                case "f":
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("does not have any description");
                    break;

            }
            Console.ReadKey();
        }
    }
}
