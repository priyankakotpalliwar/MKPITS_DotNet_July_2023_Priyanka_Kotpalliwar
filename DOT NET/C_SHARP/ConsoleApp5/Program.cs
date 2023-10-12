using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte b;
            //Console.WriteLine("byte value" + b);
            Console.WriteLine("enter byte");
            b=Convert.ToByte(Console.ReadLine());
            Console.WriteLine("byte = " + b);
            Console.ReadKey();

        }
    }
}
