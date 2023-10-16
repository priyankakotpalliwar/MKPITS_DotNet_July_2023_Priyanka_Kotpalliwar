using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkweather
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float temperature;
            Console.WriteLine("enter temperature in centigrade");
            temperature = Convert.ToInt32(Console.ReadLine());
            if(temperature <0)
            {
                Console.WriteLine("Freezing weather");

            }
            else if(temperature >0 &&  temperature <=10)
            {
                Console.WriteLine("Very Cold weather");
            }
            else if (temperature >10&& temperature<=20)
            { Console.WriteLine("Cold weather");
            }
            else if( temperature >20 && temperature <=30)
            {
                Console.WriteLine(" Normal in Temp");
                 
            }
            else if(temperature >30 && temperature
                <=40)
            {
                Console.WriteLine("Its Hot"); 
            }
            else if(temperature >= 40)
            {
                Console.WriteLine("Its Very Hot");
            }
            else
            {
                Console.WriteLine("you can't survive in this weather");
            }
            Console.ReadKey();
        }
    }
}
