using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileassignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num=1;
            int sum=0;
             while (num <= 10)
            {
                Console.WriteLine("the natural number are" + num);
                sum = sum + num;
                num++;
            }
            Console.WriteLine(sum);
             Console.ReadKey();
        }
    }
}
