using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parametrizedconstructorandnoparameterconstrutor
{
    internal class Program
    {
        class book
        {
            int bookid;
            string author;
            string title;
            int price;

            public book()
            {
                bookid = 1;
                author = "esha";
                title = "life";
                price = 250;
            }
            public book(int bookid, string author, string title, int price)
            {
                this.bookid = bookid;
                this.author = author;
                this.title = title;
                this.price = price;
            }
            public void display()
            {
                Console.WriteLine("book id"+bookid);
                Console.WriteLine("author " +author);
                Console.WriteLine("title "+title);
                Console.WriteLine("price"+price);
            }

        }
        static void Main(string[] args)
        {
            book b1= new book();
            b1.display();

            book b2 = new book(1,"oracle","ashish",400);
            b2.display();
            Console.ReadKey();
        }
    }
}
