using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OUTofmemoryException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "bobbydd";
            string subject = "english";
            Console.WriteLine("name lenght is "+name.Length);
            StringBuilder sb= new StringBuilder(name.Length,name.Length);
            try
            {
                sb.Append(subject);
            }
            catch(ArgumentOutOfRangeException priyanka) 
            {
                Console.WriteLine(priyanka.ToString());
            }
        Console.ReadKey();
        }

    }
}
