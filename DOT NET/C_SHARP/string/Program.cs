using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("enter the name");
            name=Convert.ToString(Console.ReadLine());
            Console.WriteLine("hello :" + name);
            Console.ReadLine();
        }
    }
}
