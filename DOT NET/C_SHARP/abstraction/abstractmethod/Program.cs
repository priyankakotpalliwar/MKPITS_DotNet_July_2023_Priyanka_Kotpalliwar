using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractmethod
{
   abstract class person
    {
        //abstract method
        public abstract void display();
        public  void showdisplay()
        {
            Console.WriteLine("this is without abstact method");

        }
    }
    class animal:person

    { public override void display()
        {
            Console.WriteLine("hello from display merthod");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            person p= new animal();
            p.display();
            p.showdisplay();
            Console.ReadKey();
        }
    }
}
