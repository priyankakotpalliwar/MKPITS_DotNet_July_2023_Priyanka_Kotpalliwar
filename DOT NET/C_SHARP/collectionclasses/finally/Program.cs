using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @finally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int num;
            Console.WriteLine("enter the number 1 ");
            n= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 2");
            num= Convert.ToInt32(Console.ReadLine());
            int res = 0;
            try
            {
                res = n / num;

            }
            catch
            {
                Console.WriteLine("this will block the execution");
            }
            finally 
            {
                Console.WriteLine("this bock is excuting");
                Console.WriteLine("result " + res);

            }
            Console.ReadKey();
        }
    }
}
