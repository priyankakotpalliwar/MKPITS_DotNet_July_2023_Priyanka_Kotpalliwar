using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace post_increment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = i++;
            
           

            Console.WriteLine("the value of i  " + i + "\n the value of j  " +j);
            Console.ReadKey();
        }
    }
}
