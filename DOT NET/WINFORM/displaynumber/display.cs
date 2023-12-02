using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace displaynumber
{
    internal class display
    {
        int i=1;
        int n;
        public string call(int n)
        {
            StringBuilder sb = new StringBuilder();
            while (n >=i)
            {
                
                sb.Append("\t"+i);
                i++;
                
             
            }
            return sb.ToString();
            
                }
    }
}
