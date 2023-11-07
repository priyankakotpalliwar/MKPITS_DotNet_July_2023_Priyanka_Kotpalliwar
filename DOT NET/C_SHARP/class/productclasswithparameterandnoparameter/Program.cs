using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace productclasswithparameterandnoparameter
{
    class Product
    {
        int productid;
        string productname;
        int price;
        int quantity;

        public Product() { 
        productid= 1;
            productname = "shampoo";
            price = 67;
            quantity = 2;
        }
        public Product(int productid, string productname, int price, int quantity)
        {
            this.productid = productid;
            this.productname = productname;
            this.price = price;
            this.quantity = quantity;
        }
        public void display()
        {
            Console.WriteLine(" product id " + productid);
            Console.WriteLine("productname " + productname);
            Console.WriteLine(" price "+price); Console.WriteLine("quantity "+ quantity);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product pr = new Product();
            pr.display();

            Product pr1= new Product(1,"glu",29,1);
            pr1.display();
            Console.ReadKey();
        }
    }
}
