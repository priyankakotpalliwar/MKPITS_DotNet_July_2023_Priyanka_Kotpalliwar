using System;
using System.Collections;

namespace capacity
{
    internal class Program
    {
        static void Main(string[] args)

        {
            ArrayList array = new ArrayList();
            array.Add(5);
            array.Add(8);
            array.Add(3);
            array.Add(4);

            foreach(object obj in array)
            {
                Console.WriteLine("roll no = "+obj);
            }
            Console.WriteLine("capacity: {0}", array.Capacity);
            Console.WriteLine("Count : {0}", array.Count);
            Console.ReadKey();
        }
    }
}
