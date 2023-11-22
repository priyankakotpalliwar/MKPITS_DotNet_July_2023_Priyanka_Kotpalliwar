using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankwithtwoabstractmethod
{
    abstract class Account
    {
    
        public int bal = 1000;
        public abstract void deposit(int amt);
        public abstract void withdrawl(int amt);
        public void showbalance()
        {
            Console.WriteLine(
                "balance is " + bal);
        }

    }
    class saving:Account
    {
        public override void deposit(int amt)
        {
            int interest = 500;
            bal= bal+amt+interest;
            Console.WriteLine("balance with interset " + bal);
        }
        public override void withdrawl(int amt)
        {
            bal=bal-amt;
        }
    }
    class current:Account
    {
        public override void deposit(int amt)
        {
            bal= bal+amt;
            Console.WriteLine("balance without interest  " + bal);
        }
        public override void withdrawl(int amt)
        {
            bal=bal-amt;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Account act = null;
            Console.WriteLine("enter amount ");
           int  amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter saving or current");
            string acttypye= Convert.ToString( Console.ReadLine());
            Console.WriteLine("enter deposit or withdrawl");
           string tt= Convert.ToString( Console.ReadLine());
            if(acttypye=="saving")
            {
                act = new saving();
            }
            else if(acttypye=="current")
            {
                act = new current();
            }
            if(tt =="withdrawl")
            {
                act.withdrawl(amount);
            }
            else if(tt =="deposit")
            {
                act.deposit(
                    amount);
            }
            act.showbalance();
            Console.ReadKey();
        }
    }
}
