using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace char_datatype_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char b = 'A';
            Console.WriteLine(b);
            Console.WriteLine("enter the value");
            b = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("the value is" +b);
            Console.ReadKey();
        }
    }
}
