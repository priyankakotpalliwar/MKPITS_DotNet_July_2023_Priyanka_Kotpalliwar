using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intanduint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4 byte
            int b1 = 3900;
            Console.WriteLine("value is " + b1);
            Console.WriteLine("enter int");
            b1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the value is " + b1);
            uint b2 = 3500;
            Console.WriteLine("value is" + b2);
            Console.WriteLine("enter uint");
            b2 = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("the value is" + b2);
            Console.ReadLine();
        }
    }
}
