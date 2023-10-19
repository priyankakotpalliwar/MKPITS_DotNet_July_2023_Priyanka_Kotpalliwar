using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int table=1;
            int i;
            Console.WriteLine("enter the number");
            num=Convert.ToInt32(Console.ReadLine());
            for( i = 1; i <=10; i++)
            {
                table = num * i;
                Console.WriteLine("{0}*{1}={2}", num, i, table);
            }
          
            Console.ReadKey();
        }
    }
}
