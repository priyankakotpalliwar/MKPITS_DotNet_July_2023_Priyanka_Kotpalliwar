using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileevenno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            while (counter <= 100000)
            {
                if (counter % 2 == 0)
                {
                    Console.WriteLine("{0} is even ", counter);
                }
                counter = counter + 1;
            }


            Console.ReadKey();


        }
    }
}
