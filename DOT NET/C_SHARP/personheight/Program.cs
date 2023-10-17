using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personheight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float height;
            Console.WriteLine("enter the height ");
            height=Convert.ToInt32(Console.ReadLine());
            if(height <150.0f) {
                Console.WriteLine("the person is drawf");
            }
            else  if(height>150.0f && height<=165.0f){
                Console.WriteLine("the person  is average height");

            }
            else if(height>165.0f &&height <=195.0f)
            {
                Console.WriteLine("the person is taller");
            }
            Console.ReadKey();
        }
    }
}
