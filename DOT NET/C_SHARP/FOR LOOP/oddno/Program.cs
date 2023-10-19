using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int counter = 0;
            Console.WriteLine("enter the num");
            num=Convert.ToInt32(Console.ReadLine());
            int sum = 1;
            while(true) {
            
                if(sum<=num)
                {
                    if(counter%2!=0)
                    {
                        Console.WriteLine(" odd no :{0}", counter);
                        sum = sum + 1;
                    }
                }
                else
                {
                    break;
                }
                counter++;
            }
            Console.ReadKey();
            
            
        }
    }
}
