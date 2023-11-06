using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productclass
{
    class product
    {
        int productid;
        string productname;
        int price;
        int quantity;

        public  product()
        {
            productid = 2;
            productname = "soap";
            price = 250;
            quantity = 3;

        }
        public void display()
        {
            Console.WriteLine("product id -"+productid);
            Console.WriteLine("product name -"+productname);
            Console.WriteLine("price -" +price+"$");
            Console.WriteLine(" Quantity - "+ quantity);

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            product pr = new product();
            pr.display();
            Console.ReadKey();
        }
    }
}
