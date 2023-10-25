using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileloopexample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //print number from 5 to 1
            int counter=5;
            while(counter >= 1)
            {

                
                Console.WriteLine(counter);
                counter=counter-1;
            }
            Console.ReadKey();
        }
    }
}
