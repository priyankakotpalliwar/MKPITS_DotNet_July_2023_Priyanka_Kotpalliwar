using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritingmethods
{
    public class Animal
    {
        public void eat()
        {
            Console.WriteLine("eating ");
            
        }

    }
    public class dog:Animal
    {
      public void bark()
        {
            Console.WriteLine("barkingg");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            dog d = new dog();
            d.eat();
            d.bark();
            Console.ReadKey();
        }
    }
}
