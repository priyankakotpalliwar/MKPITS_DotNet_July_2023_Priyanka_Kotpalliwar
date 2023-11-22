using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankdepositandsaving
{
   abstract class Account
    {
        public int actno;
        public int bal = 1000;
        public abstract void deposite(int amt);
        public void showbalance() {


            Console.WriteLine("the act-no is {0} and bal is{1}", actno, bal);
        }


    }
    class current : Account
    {
        public override void deposite(int amt)
        {
          bal=bal+amt;  
        }
    }
    class saving:Account
    {
        public override void deposite(int amt)
        {
            int intrest =200;
            bal=bal+amt+intrest;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter acctno");
            int actno=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter amount you want to deposite");
            int amt=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the acount type \n saving\ncurrent");
            string acttype=Convert.ToString(Console.ReadLine());
            Account acc = null;
            if(acttype== "saving")
            {
                acc= new saving();
            }
            else if(acttype=="current")
            {
                acc= new current();
            }
            acc.actno=actno;
            acc.deposite(amt);
            acc.showbalance();
            Console.ReadKey();
        }
    }
}
