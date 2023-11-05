using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloadingwithparameter
{
    class Book
    {
        int bookid;
        string title;
        //creating a overlaoded method with 4 parameters
        public void getdata(int bookid, string title)
        {
            Console.WriteLine("method  with  integer first called");
            this.bookid = bookid;
            this.title = title;


        }
        public void getdata(string title, int bookid)
        {
            this.bookid = bookid;
            this.title = title;

        }
        public void display()
        {
            Console.WriteLine("book id : " + bookid);
            Console.WriteLine("title : " + title);


        }
    }
    internal class Program
    {
        
            static void Main(string[] args)
        {
            Console.WriteLine("enter bookid");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter title");
            string t1 = Console.ReadLine();
            ;

            Book b2 = new Book();
            b2.getdata(b1, t1); //this will call method with parameters
            b2.display();
            Console.WriteLine("passing string first then integer");
            b2.getdata(t1, b1);
            b2.display();
            Console.ReadLine();
        }
    }
}
