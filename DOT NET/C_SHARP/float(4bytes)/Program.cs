using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace float_4bytes_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float b1;
            Console.WriteLine("enter a float value");
            b1=Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("value is" + b1);
            Console.ReadKey();
        }
    }
}
