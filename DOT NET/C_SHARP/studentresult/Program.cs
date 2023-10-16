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
            string name;
            int rollno,totalmarks;
            float percentage;
            int marksinphysics, marksinchemistry, marksincomputer;
            Console.WriteLine("Report card");
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
            percentage = totalmarks /300 *100;
            Console.WriteLine("percwntage "+ percentage);
            Console.ReadKey();

        }
    }
}
