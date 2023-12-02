using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greaternumber
{
    internal class greater
    {
        int n1;
        int n2;
        public string  greaternum(int n1,int n2)
        {
             string a=null;
            if (n1 < n2)
            {
                a= "number 2 is greater \t" + n2;
            }
            else
            {
                a = "number 1 is greater \t" + n1;
            }

            return a;
        }
    }
}
