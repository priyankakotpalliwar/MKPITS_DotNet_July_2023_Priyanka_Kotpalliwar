using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankTranscation
{
    internal class Program
    {
        class BankAccount
        {
            public int AccountNumber { get; set; }
            public string AccountHolderName { get; set; }
            public int Balance { get; set; }

            public void display()
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("account details of  customer :");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("account number" + AccountNumber);
                Console.WriteLine("account holder name " + AccountHolderName);
                Console.WriteLine("Balance :" + Balance);
            }
            public void transfer(BankAccount ba)
            {
                Balance = Balance + ba.Balance;
                ba.Balance = 0;
            }
            public void showbalance()
            {
                Console.WriteLine("current balance account no {0} is {1} " , AccountNumber ,Balance);

            }
        }
        static void Main(string[] args)
        {
            BankAccount bank=new BankAccount();
            bank.AccountNumber = 1;
            bank.AccountHolderName = "priyanka";
            bank.Balance = 1000;
            bank.display();
            
            BankAccount b2= new BankAccount();
            b2.AccountNumber = 2;
            b2.AccountHolderName = "shreya";
            b2.Balance = 1000;
            b2.display();
            
            bank.transfer(b2);
            Console.WriteLine("--------------");
            Console.WriteLine("Balance After Transaction");
             bank.showbalance
                ();
            b2.showbalance();
            Console.ReadKey();

        }
    }
}
