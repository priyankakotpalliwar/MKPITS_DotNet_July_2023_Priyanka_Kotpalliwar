using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryand_catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int num;
            Console.WriteLine("enter number 1");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 2");
            num = Convert.ToInt32(Console.ReadLine());
            int res = 0;
            try
            {
                res = n / num;
            }
            catch (Exception eee)
            {

                Console.WriteLine("the number can't be divided as error occured");
            }
            Console.WriteLine("res = " + res);
            Console.WriteLine("bye");
            Console.ReadKey();
        }
    }
}
