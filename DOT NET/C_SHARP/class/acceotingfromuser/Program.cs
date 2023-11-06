using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acceotingfromuser
{
    class book
    {
         int bookid;
        string title;
        string author;
        int price;

        public book(int bookid,string title,string author,int price) //parametrised
                                                                     { 
        
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;
        
        }
        public void display()
        {
            Console.WriteLine("bookid " + bookid);
            Console.WriteLine("title  "+title);
            Console.WriteLine("author " + author);
            Console.WriteLine("price " + price);
        }
    }
    internal class Program


    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter bookid");
            int b1= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter title ");
            string t1= Console.ReadLine();

            Console.WriteLine("enter author");
            string a1= Console.ReadLine();
            Console.WriteLine("price");
            int p1= Convert.ToInt32(Console.ReadLine());

            book bo = new book(b1,t1,a1,p1);
            bo.display();
            Console.ReadKey();


        }
    }
}
