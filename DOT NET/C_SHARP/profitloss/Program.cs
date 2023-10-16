using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace profitloss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  buyingprice,sellingprice,loss,profit;
            Console.WriteLine("enter the buying  prize");
            buyingprice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the selling pricee");
            sellingprice = Convert.ToInt32(Console.ReadLine());
            if(buyingprice > sellingprice) 
            {
                loss = buyingprice - sellingprice;
                Console.WriteLine("you are in loss of " + loss);
            }
            else if(buyingprice < sellingprice) 
            {
                profit=sellingprice - buyingprice;
                Console.WriteLine("you are in profit of Rs" + profit);
            }
            else if(buyingprice == sellingprice)
            {
                Console.WriteLine("thierr is neither profit nor loss");
            }
            Console.Read();
            

        }
    }
}
