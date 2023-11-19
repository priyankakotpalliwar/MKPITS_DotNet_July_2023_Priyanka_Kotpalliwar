using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace runtimePOLYMORPHISM
{
   class baseclass
    {
        public virtual  void method()
        {
            Console.WriteLine("hello from public virtual void");

        }
    }
    class childclass:baseclass
    {public override void method()
        {
            Console.WriteLine("hello from overide  void method   ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            baseclass b1= new childclass();
            b1.method();
            Console.ReadKey();
        }
    }
}
