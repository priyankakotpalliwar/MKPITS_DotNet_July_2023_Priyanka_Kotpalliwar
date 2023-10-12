using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace short_and_ushort
{
    internal class Program
    {
        static void Main(string[] args)
        {
         //4bytes
              short b = 25890;
            Console.WriteLine(" value " + b);
            Console.WriteLine("enter short");
            b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("value = " + b);

            ushort b1;
            Console.WriteLine("enter ushort datatype :");
            b1 = Convert.ToUInt16(Console.ReadLine());
            /*b1 = Convert.ToInt16(Console.ReadLine());
 */           Console.WriteLine("VALUE IS "+ b1);
            Console.ReadKey();




        }
    }
}
