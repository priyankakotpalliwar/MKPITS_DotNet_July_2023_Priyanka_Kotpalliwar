using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vowelsornot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string alphabet;
            Console.WriteLine("enter the alphabet");
            alphabet=Convert.ToString(Console.ReadLine());
            if(alphabet=="a"|| alphabet=="e"||alphabet=="i"||alphabet=="o"||alphabet=="u")
            {
                Console.WriteLine("it is a vowel");
            }
            else
            {
                Console.WriteLine(" it a constant.");

            }
            Console.ReadKey();
            
        }
    }
}
