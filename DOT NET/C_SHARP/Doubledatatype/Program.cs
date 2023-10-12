using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doubledatatype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double d1;
            Console.WriteLine("enter the double");
            d1= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("the value is " + d1);
            Console.ReadKey();
        }
    }
}
