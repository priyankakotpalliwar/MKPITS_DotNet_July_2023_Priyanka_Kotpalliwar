using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangleclass
{
    internal class Program
    {
        class rectangle
        {
            int width;
            int height;
            int areaofrectangle;


            public void getdata(int width, int height)
            {
                this.width = width;
                this.height = height;
              

            }
            public void display()
            {
                areaofrectangle = width * height;
                Console.WriteLine(" area of rectangle is" + areaofrectangle);
            }
        }
        static void Main(string[] args)

        {
            rectangle rect=new rectangle();
            rect.getdata(5, 10);
            rect.display();
            Console.ReadKey();
        }
    }
}
