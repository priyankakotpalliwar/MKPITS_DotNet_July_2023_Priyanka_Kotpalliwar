using System;
using System.Collections;


namespace hasttables
    
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("001", "zara");
            ht.Add("002", "zoya");
            ht.Add("003", "alfiya");
            ht.Add("004", "rukiya");
            ht.Add("005", "salrmma");
            if(ht.ContainsValue("zoha"))
            {
                Console.WriteLine("it is present");

            }
            else
            {
                ht.Add("006", "zoha");

            }
            // get  collections key
            ICollection key = ht.Keys;
            foreach(string k in key)
            {Console.WriteLine(k + ":" + ht[k]);

            }
            Console.ReadKey();
        }
    }
}
