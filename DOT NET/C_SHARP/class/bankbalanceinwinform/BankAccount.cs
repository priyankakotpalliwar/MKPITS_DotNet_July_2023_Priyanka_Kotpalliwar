using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankbalanceinwinform
{
    internal class BankAccount
    {
        public int AccountNumber {  get; set; }
        public string AccountHoldername {  get; set; }
        public int  Balance { get; set; }
       
        public void transfer(BankAccount ba)
        {
            Balance=Balance+ba.Balance;
            ba.Balance = 0;

        }
        
    }
}
