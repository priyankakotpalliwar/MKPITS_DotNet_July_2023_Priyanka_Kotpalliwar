using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gotostatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                goto Even;
            }
            else
            {
                goto End;
            }

            Console.WriteLine("odd no");

            /*goto End;*/
        Even:
            Console.WriteLine("even no");
        End:
            Console.WriteLine("bye");



            Console.ReadKey();

        }
    }
}
