using System;
using System.Collections;

namespace removeMETHOD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            arr.Add(10);
            arr.Add(20);
            arr.Add(30);
            Console.WriteLine(" displaying array list");
            foreach(object obj  in arr)
            {
                Console.WriteLine("object is "+obj);

            }
            Console.WriteLine("removing 10 from array list");
           arr.Remove(10);
            foreach(object obj in arr)

            {
                Console.WriteLine("object is "+obj);
            }
            Console.WriteLine("array list colection after removing 0");
            arr.RemoveAt(0);
           foreach(object obj in arr)
            {
                Console.WriteLine("object is" + obj);
            }
           Console.ReadKey();
        }
    }
}
