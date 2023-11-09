using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copyconstructor
{
    class book
    {
        int bookid;
        string title;

        public book()

        {
            bookid =1;
            title = "vb.net";



        }
        public book(book b2)
        {
            bookid = b2.bookid;
            title = b2.title;


        }
        public void display()
        {
            Console.WriteLine("book id of the book is "+ bookid);
            Console.WriteLine("title of  the book id "+ title);

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            book book1 = new book();
            book book2 = new book();

            Console.WriteLine("book 1 details    ");
           book1.display();
            Console.WriteLine(" book 2 details  ");
            book2.display();
              

            Console.ReadKey();
           
        }
    }
}
