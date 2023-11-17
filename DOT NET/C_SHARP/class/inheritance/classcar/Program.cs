using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classcar
{
    class car
    {
        public void start()
        {
            Console.WriteLine("car is starting");

        }
        
    }
    class wagonar:car { 
    public void engine()
        {
            Console.WriteLine("enginee is starting");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            wagonar wag= new wagonar();
            wag.start();
            wag.engine();
            Console.ReadKey();
        }
    }
}
