using System;
using System.Collections;


namespace Collectionclasses
{

    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
                ar.Add("priyan");
            ar.Add("shreya");
            ar.Add("ojefa");
            ar.Add("huzzefa");
            foreach(object obj in ar)
            {
                Console.WriteLine("object are "+obj);
                Console.ReadKey();
            }
            /*Console.ReadKey();*/
        }
    }
}
