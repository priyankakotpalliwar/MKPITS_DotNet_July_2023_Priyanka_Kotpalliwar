using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SORTmethodin_DS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();

            sl.Add("001", "shreya");
            sl.Add("002", "supriya");
            sl.Add("003", "sherya");
            sl.Add("004", "pidi");
             
            if(sl.ContainsValue("nakiya "))
            {
                Console.WriteLine("is present in stored list");

            }
            else
            {
                sl.Add("005","nakiya");
            }
            // get a collection of the keys. 
            ICollection key = sl.Keys;
            foreach(string str  in key)
            {
                Console.WriteLine(str + ":" + sl[str]);
            }
            Console.ReadKey();

        }
    }
}
