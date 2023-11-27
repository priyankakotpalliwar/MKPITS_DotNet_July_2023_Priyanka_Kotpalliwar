using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> li = new List<string>();
            li.Add("a");
            li.Add("ba");
            li.Add("shree");
            li.Add("niwas");
            li.Add("kalayan");

            Console.WriteLine(li.Contains("a"));
            Console.WriteLine(li[1]);
            Console.WriteLine(li[2]);
            Console.WriteLine(li.Remove("a"));
            Console.WriteLine(li.Remove("ba"));
            Console.WriteLine(li.Contains("a"));
            li.Insert(0, "ao");
            Console.WriteLine(li.Contains("ao"));
            li.Sort();
            foreach(string like in li)
            {
                Console.WriteLine(like);
            }
            Console.ReadKey();
        }
    }
}
