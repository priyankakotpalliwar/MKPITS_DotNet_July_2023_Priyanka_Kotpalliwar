using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Bookclass
{
    internal class Program
    {
        class Bookclass
        {
            string title;
            string author;
            int publicationyear;
            public void  getdata(string title, string author, int publicationyear)
            {
                this.title = title;
                this.author = author;
                this.publicationyear = publicationyear;

            }
            public void displaydata()
            {
                Console.WriteLine("title  " + title);
                Console.WriteLine("author "+ author);
                Console.WriteLine("publicaton year  " + publicationyear);
            }

        }
        static void Main(string[] args)
        {
            Bookclass[] bookid = new Bookclass[3];
            bookid[0] = new Bookclass();
            bookid[1] = new Bookclass();
            bookid[2] = new Bookclass();
            string auth = null;
            string tit = null;
            int publication=0;
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("enter author");
                auth=Console.ReadLine();

                Console.WriteLine("enter title");
                tit=Console.ReadLine();
                Console.WriteLine("enter publicaton year");
                publication=Convert.ToInt32(Console.ReadLine());
                bookid[i].getdata(auth,tit,publication);
            }
            for(int i = 0;i < 3;i++)
            {
                bookid[i].displaydata();    

            }
            Console.ReadKey();
        }
    }
}
