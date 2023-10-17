using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace corodinatepoints
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x_cordinates, y_cordinates;
            Console.WriteLine("enter the x_cordinates");
            x_cordinates=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the y-cordinates");
            y_cordinates = Convert.ToInt32(Console.ReadLine()); 
            if(x_cordinates>=0 && y_cordinates>=0)
            {
                Console.WriteLine("then the points are in first quadrant");
            }
            else if(x_cordinates>=0 && y_cordinates<=0)
            {
                Console.WriteLine(" then points are in second quaddrant");

            }
            else if(x_cordinates<=0 && y_cordinates<=0)
            {
                Console.WriteLine("then the points lies in third quadrant");
            }
            else
            {
                Console.WriteLine("then the pointes lies in fourth quadrant");
            }
            Console.ReadKey();
        }
    }
}
