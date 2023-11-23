using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_inwidowsform
{
    abstract class Account
    {


        public int actno;
        public int bal = 1000;
        public int withdrwal;
        public abstract string deposit(int a,int b);
        public string showbalance()
        {
            return "bal is" + bal;
        }


    }
    class saving:Account
    {
        public override string deposit(int a, int b)
        {
            int interest = 500;
            bal=bal+b+interest;
           actno= a;
            return "bal is " + bal;


        }
    }
    class current:Account
    {
        public override string deposit(int a,int b)
        {
            bal = bal + b;
            return "bal is" + bal;
        }
    }
}
