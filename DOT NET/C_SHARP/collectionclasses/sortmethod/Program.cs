using System;
using System.Collections;


namespace sortmethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();  
            arr.Add(10);
            arr.Add(200);
            arr.Add(6);
            arr.Add(2);
            foreach(object obj in arr)
            {
                Console.WriteLine("object in array list are "+obj);
            }
            //sorting
            arr.Sort();
            foreach(object obj in arr)
            {
                Console.WriteLine("object after sort method "+obj);
            }
            Console.ReadKey();

        }
    }
}
