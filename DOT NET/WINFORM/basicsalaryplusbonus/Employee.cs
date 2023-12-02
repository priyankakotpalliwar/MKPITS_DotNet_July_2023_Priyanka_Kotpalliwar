using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicsalaryplusbonus
{
    internal class Employee
    {
        int bonous = 0;
        string designation = null;

        int totalsalary =0;
         public int basesalary = 0;
       
        public int count(int basesalary, string designation)
        {
            switch(designation) 
            {
                case "m":

                    bonous = 5000;
                    totalsalary=bonous+basesalary;
                    break;
                case "p":
                    bonous = 1000;
                    totalsalary=bonous+basesalary;
                    break;
                case "clerk":
                    bonous=500;
                    totalsalary=bonous+basesalary;
                    break;
                default:
                    bonous=0;
                    totalsalary = bonous + basesalary;
                    break;
            }
            return totalsalary;
        }

    }
}
