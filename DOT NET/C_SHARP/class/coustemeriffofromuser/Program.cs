using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coustemeriffofromuser
{
    internal class Program
    {
        class coustmer
        {
            string coustmer_name;
            int coustmer_id;
            
            public void getdata(string coustmer_name, int coustmer_id)
            {
               this. coustmer_id= coustmer_id;
               this.coustmer_name = coustmer_name;

            }
            public void display()
            {
                Console.WriteLine("COUSTMER NAME  "+   coustmer_name);
                Console.WriteLine("coustemer id "+ coustmer_id);
            }

        }
        static void Main(string[] args)
        {
            coustmer cust = new coustmer();
            Console.WriteLine("enter coustemer code and name");
            int cc= Convert.ToInt32(Console.ReadLine());
            string cn = Convert.ToString(Console.ReadLine());
            cust .getdata(cn, cc);
            cust.display();
            Console.ReadKey();
        }
    }
}
