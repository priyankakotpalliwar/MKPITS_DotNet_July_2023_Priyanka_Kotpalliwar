using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace electricbill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string coustemername;
            int coustemerID;
            float totalamount;
            float surcharge=0;
                float unitconsumed;
            float amountcharged=0;
            Console.WriteLine("                             Electric bill");
            Console.WriteLine("enter coustemer name");
            coustemername =Convert.ToString( Console.ReadLine());
            Console.WriteLine("enter coustemer ID");
            coustemerID = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("enter unit consumed");
            unitconsumed = Convert.ToInt32( Console.ReadLine());
            if (unitconsumed <= 199)
            {

                amountcharged = 1.20f * unitconsumed;
                Console.WriteLine("Amount Charges @Rs. 1.20 per unit : " + amountcharged);
            }
            else if (unitconsumed <= 400 && 200 <= 400)
            {
                amountcharged = 1.50f * unitconsumed;
                Console.WriteLine("amount charges @Rs.1.50 per unit :" + amountcharged);
            }
            else if (unitconsumed <= 600 && 600 >= 400)
            {
                amountcharged = 1.80f * unitconsumed;
                Console.WriteLine("amount charges @Rs.1.80 per unit :" + amountcharged);
            }
            else if (unitconsumed >= 600)
            {
                amountcharged = 2.00f * unitconsumed;
                Console.WriteLine("amount charges @Rs.2.00 per unit :" + amountcharged);
            }

            if (amountcharged <= 99)
            {
                amountcharged = 100;
            }
            else if(amountcharged >=400)
            {
                surcharge = 0.15f * amountcharged;
                
                Console.WriteLine("surcharge :"+surcharge);
            }
            totalamount = surcharge + amountcharged;
            Console.WriteLine("totalamount" +totalamount);
            Console.ReadKey();
         
        }
    }
}
