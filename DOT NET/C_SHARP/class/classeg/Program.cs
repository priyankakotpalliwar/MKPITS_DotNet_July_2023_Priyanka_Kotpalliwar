using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classeg
{
    internal class Program
    {
        class customer
        {
           public  int customer_code;
           public string customer_name;
        }
        static void Main(string[] args)
        {
            customer cust =new customer();
            cust.customer_code = 123;
            cust.customer_name = "arjun";
            Console.WriteLine("customer code "+cust.customer_code+"\ncustomer name "  + cust.customer_name);
            Console.ReadKey();

            
        }
    }
}
