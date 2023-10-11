using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AREAOFRECTANGLE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int l, b, area;
            Console.WriteLine("enter the length");
            l=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the breath");
            b=Convert.ToInt32(Console.ReadLine());
            area = l * b;
            Console.WriteLine("the area of rectangle" + area);
            Console.ReadKey();
        }
    }
}
