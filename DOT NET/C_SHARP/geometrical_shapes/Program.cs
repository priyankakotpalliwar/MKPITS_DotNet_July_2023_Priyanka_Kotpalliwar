using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometrical_shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float r,b,h,l,w;
            float areaofcircle, areaoftriangle, areaofsquare,areaofrectangle,areaofparallelogram;
            string choice;
            Console.WriteLine("input your choice \n 1): To calculate area of circle\n 2) :To calculate area of triangle\n 3):To calulate  area square\n 4): To calculte area of rectangle \n 5) To calulate area of parallelogram \n 6) exit");
            choice=Convert.ToString(Console.ReadLine());    
            if(choice == "1")
            {
                Console.WriteLine("input radius  of circle");
                r =Convert.ToInt32(Console.ReadLine());
                areaofcircle = 3.14f * r *r;
                Console.WriteLine("area of circle is" + areaofcircle);
            }
            else if(choice == "2")
            {
                Console.WriteLine("input breadth ");
                b= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("input height");
                h= Convert.ToInt32(Console.ReadLine());
                areaoftriangle = 0.5f * b * h;
                Console.WriteLine("area of triangle" + areaoftriangle);



            }
            else if(choice == "3")
            {
                Console.WriteLine("input lenght ");
                l= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("intput breath");
                b= Convert.ToInt32(Console.ReadLine());
                areaofsquare = l * b;
                Console.WriteLine("area of sqaure is" + areaofsquare);
            }
            else if(choice == "4")
            {
                Console.WriteLine("input your lenght");
                l = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("input width");
                w= Convert.ToInt32(Console.ReadLine());
                areaofrectangle = l * w;
                Console.WriteLine("area of rectangle " + areaofrectangle);

            }
            else if(choice == "5") 
            {
                Console.WriteLine("input breadth ");
                b=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("input height");
                h= Convert.ToInt32(Console.ReadLine());
                areaofparallelogram = b * h;
                Console.WriteLine("area of prallelogram is" + areaofparallelogram);
            }
            else
            {
                Console.WriteLine("exit"); 
            }
            Console.ReadKey();
        }
    }
}
