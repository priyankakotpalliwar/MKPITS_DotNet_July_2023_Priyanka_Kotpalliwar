using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractioneg2
{
    abstract class bank
    {
        public abstract void saving();
    }
    class deposit:bank { 

        public  override  void saving()
        {
            Console.WriteLine("saving from account");

        }
    
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            bank b=new deposit();
            b.saving();
            Console.ReadKey();
        }
    }
}
