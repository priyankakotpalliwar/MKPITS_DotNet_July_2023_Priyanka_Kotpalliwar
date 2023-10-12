using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longandulong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long b;
            Console.WriteLine("enter the value");
            b= Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("the value" + b);
            //for negative as well as positive no.
            ulong b1;
            Console.WriteLine("enter the value");
            b1= Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("THE U LONG IS" + b1);
            Console.ReadKey();

        }
    }
}
