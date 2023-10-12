using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boolean_datatype_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool b1 ;
           
            Console.WriteLine("enter the bool value");
            b1=Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("value is" + b1);
            Console.ReadLine();
        }
    }
}
