using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodinoneinteeger
{
    internal class Program
    {
        static void addition(int num)
        {
            int res = 1;
            res = num + num;
            Console.WriteLine("addition"+res);
                }
        static void Main(string[] args)
        {
            addition(5);
            Console.ReadKey();
        }
    }
}
