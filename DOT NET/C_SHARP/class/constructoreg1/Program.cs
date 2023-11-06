using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructoreg1
{
    class book
    {
        int bookid;
        string title, author;
        int price;


        public book()
        {
            bookid = 2;
            title = "mathematics";
            author = "R D Sharma";
            price = 256;

        }
        public void display()
        {
            Console.WriteLine(" BOOK Id - " + bookid);
            Console.WriteLine("Title Of Book - " + title);
            Console.WriteLine("author -  " + author);
            Console.WriteLine("Price -  " + price);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            book b = new book();
            b.display();
            Console.ReadLine();
        }
    }
}
