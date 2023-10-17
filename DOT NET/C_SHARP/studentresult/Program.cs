using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentresult
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name,division;
            int rollno,totalmarks;
            float percentage;
            int marksinphysics, marksinchemistry, marksincomputer;
            Console.WriteLine("                                         Report card");
            Console.WriteLine("enter the name");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("enter the roll no");
            rollno=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter marks in physics");
            marksinphysics=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the marks in chemistry");
            marksinchemistry=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the marks in computer application");
            marksincomputer=Convert.ToInt32(Console.ReadLine());
            totalmarks=marksinphysics+marksinchemistry+marksincomputer;
            percentage = totalmarks /3.0f;
            Console.WriteLine("percentage "+ percentage);
            if (percentage >= 60)
            {
                division = "first";
            }
            else if (percentage < 60 && percentage >= 48)
            {
                division = "second";

            }
            else if (percentage <= 48 && percentage >= 38)
            {
                division = "pass";
            }
            else
            {
                division = "fail";
            }
            Console.WriteLine("division of student is " + division);
            Console.ReadKey();

        }
    }
}
