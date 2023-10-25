using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumoftheno1to5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int sum = 0;
            while(num<=5)
            {
                sum=sum+num;
                num++;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
