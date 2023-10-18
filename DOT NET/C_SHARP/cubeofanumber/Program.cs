using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cubeofanumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int cube = 0;
            int num2 = 0;

            Console.WriteLine("Enter the num");
            num2=Convert.ToInt32(Console.ReadLine());
            

            while(num<=num2){
                cube = num * num * num;
                num++;
                Console.WriteLine(cube);
            }
           
            Console.ReadKey();
        }
    }
}
