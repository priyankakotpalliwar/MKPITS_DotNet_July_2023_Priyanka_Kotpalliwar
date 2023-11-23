using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keywordofsealed
{
    class person
    {
        public virtual void display()
        {
            Console.WriteLine("hello from virtual display");
        }

    }
    class student : person
    {
        public sealed override void display()
        {
            Console.WriteLine("hello from sealed overide");
        }
    }
    class parttime:student
    {
        // public override void display()
 //cannot overide as we have sealed the function
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            parttime p1 = new parttime();
            p1.display();
            Console.ReadKey();
        }
    }
}
