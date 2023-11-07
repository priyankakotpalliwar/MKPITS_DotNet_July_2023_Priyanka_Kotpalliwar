using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace withparameterwithoutparameteranduserinput
{
    internal class Program
    {
        class book
        {
            int bookid;
            string title;
            string author;
            int price;

            public book()
            {
                bookid = 1;
                title = "araya";
                author = "disney hotstar";
                price = 200;

            }
            public book(int bookid, string title, string author, int price)
            {
                this.bookid = bookid;
                this.title = title;
                this.author = author;
                this.price = price;
            }
            public void display()
            {
                Console.WriteLine("book id "+bookid);
                Console.WriteLine("title "+ title);
                Console.WriteLine("author "+ author);
                Console.WriteLine(" price " + price);
                
            }
        }
        static void Main(string[] args)
        {
            book b1=new book();
            b1.display();

            book b2=new book(12,"fadf","dafd",32);
            b2.display();

            Console.WriteLine("----------enter details--------------");
            Console.WriteLine("enter book id");
            int bo1=Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("enter title");
            string t1=Console.ReadLine();
            Console.WriteLine("enter author ");
            string a1=Console.ReadLine();
            Console.WriteLine("price");
            int p1=Convert.ToInt32(Console.ReadLine()); 

            book b3= new book(bo1,t1,a1,p1);
            b3.display();
            Console.ReadKey();


        }
    }
}
