using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallestone
{
    internal class age
    {
        int ageofwomen;
        string a;
        public age(int ageofwomen)
        {
            this.ageofwomen = ageofwomen;
           
            
        }
        public string check(int ageofwomen)
        {
            if(ageofwomen <= 18) 
            {
                a = "minor girl " + ageofwomen;

            }
            else if(ageofwomen >18  && ageofwomen<50)
            {
                a = "adult girl " + ageofwomen;
            }
            else if (ageofwomen >=50 )
            {
                a = " old lady " + ageofwomen;
            }
           
            return a;

        }
    }
}
