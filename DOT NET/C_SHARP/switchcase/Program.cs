using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char op;
            Console.WriteLine("enter the character");
            op=Convert.ToChar(Console.ReadLine());
            switch (op)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("these are vowels");
                    break;

                default:
                    Console.WriteLine("these are not vowels");
                    break;

                    
            }
            Console.ReadKey();
        }
    }
}
