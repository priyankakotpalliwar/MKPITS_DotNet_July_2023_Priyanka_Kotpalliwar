using System;
using System.Collections;

namespace insertmethodin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr=new ArrayList();
            arr.Add(25);
            arr.Add(35);
            arr.Add(35);
            arr.Add(6);
            foreach(object obj in arr)
            {
                Console.WriteLine("obj in arraylist "+obj);

            }
            Console.WriteLine("array list colection after adding element at 2 position");
            arr.Insert(2, 3);
                foreach (object obj in arr)
            {
                Console.WriteLine("object " + obj);
            }

                Console.ReadKey();
        }
    }
}
