using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractandnon_abstractmethod
{
     abstract class account
    {
        public abstract void deposit();
       //abstract method
        public void showbalance()
        {
            Console.WriteLine("saving is your account is quite low");

        }
    }
    class saving:account
    {
        public override void deposit()
        {
            Console.WriteLine("this is overired from the above class");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            account s= new saving();
            s.deposit();
            s.showbalance();
            Console.ReadKey();
        }
    }
}
