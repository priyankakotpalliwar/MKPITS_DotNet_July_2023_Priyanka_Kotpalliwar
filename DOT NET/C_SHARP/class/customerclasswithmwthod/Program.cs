using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customerclasswithmwthod
{
    internal class Program
    {
        class customer
        {
            int customer_no;
            string customer_name;

            public void getdata(int cn,string cname)
            {
                customer_no = cn;
                customer_name = cname;

            }
            public void display() {

                Console.WriteLine("customer no. " + customer_no);
                Console.WriteLine("customer name " + customer_name);

            }
        }
        static void Main(string[] args)
        {
            customer cust =new customer();
            cust.getdata(123, "priya");
            cust.display();

            Console.ReadKey();
        }
    }
}
