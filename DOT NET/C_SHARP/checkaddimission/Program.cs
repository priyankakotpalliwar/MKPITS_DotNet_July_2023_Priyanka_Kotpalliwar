using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkaddimission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maths, phy, chem,total;
            Console.WriteLine("enter the maths marks");
            maths=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter phyics");
            phy=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter chemistry");
            chem=Convert.ToInt32(Console.ReadLine());
            total=maths+phy+chem;
            Console.WriteLine("Total OF THREEE SUBJECT IS " + total);
            if (maths>=65 && phy>=55 && chem>=50)
            {
                Console.WriteLine("eligible to take addmission");

            }
            else if(total>=180)
            {
                Console.WriteLine("eligible to take addmission");
            }
            else
            {
                Console.WriteLine("not eligible to take addmission");
            }
          
            Console.ReadKey();

        }
    }
}
