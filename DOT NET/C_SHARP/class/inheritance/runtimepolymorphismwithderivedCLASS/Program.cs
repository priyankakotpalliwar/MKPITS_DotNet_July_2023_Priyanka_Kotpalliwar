using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace runtimepolymorphismwithderivedCLASS
{
    class drawing
    {
        public virtual void draw() {

            Console.WriteLine("drawing   ");

        }
    }
    class rectangle:drawing
    {
        public override void draw()
        {
            Console.WriteLine("drwaing rectangle");
        }
    }

    class circle:drawing
    {
        public override void draw()
        {
            Console.WriteLine("drawing circle");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            drawing d1;
            d1=new drawing();
            d1.draw();
            d1= new rectangle()
                ;
            d1.draw() ;
            d1= new circle()
                ; d1.draw() ;
            Console.ReadKey();

        }
    }
}
