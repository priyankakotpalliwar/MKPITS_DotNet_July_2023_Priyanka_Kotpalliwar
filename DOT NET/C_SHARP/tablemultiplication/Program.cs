using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablemultiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num=0;
            int multiplication;
            int counter=1;

            Console.WriteLine("enter num");
            num=Convert.ToInt32(Console.ReadLine());
            while(counter<=10)
            {
               multiplication= num * counter;
                
                Console.WriteLine("{0}*{1}={2}",num,counter,multiplication);
                counter++;
            }
            Console.ReadKey();

        }
    }
}
