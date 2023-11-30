using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    
        public abstract class Account1
        {
            public int accountno;
            public int balance=1000;
            public abstract string deposit(int amount);
            public string withdrawl(int amount)
            {
                string res = null;
                if(balance< amount)
                {
                    res = "you have unsufficient balance";

                }
                else if(balance>amount) 
                {
                    balance= balance-amount;
                    res = "you have sucessfully withdrawl"+balance.ToString();
                }
                else if (balance==amount) 
                {
                    balance = 0;
                    res = "you have sucessfully withdrawl" + balance.ToString();
                }

                return res;
               
            }
            public  string showbalance() { 
                return "balance is : "+balance.ToString();
            }

        }
        public class saving:Account1
        {
            public override string deposit(int amount)
            {
                int interset = 300;
                balance=balance+amount+interset;
                return "balance with interset "+balance.
                    ToString();
            }
        }
        public class  current:Account1
        {
            public override string deposit(int amount)
            {
                balance = balance+amount;
                return "balance in current account " + balance.ToString();
            }
        }
    
}
