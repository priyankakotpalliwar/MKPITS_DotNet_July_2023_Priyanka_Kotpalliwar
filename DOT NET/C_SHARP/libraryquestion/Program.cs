using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace libraryquestion
{
    //: Implement a simple library management system in C#.
    //Design classes for Book, Author, and Library.
    //Each book should have properties like Title, ISBN, and a reference to an Author.
    //The Library class should keep track of a collection of books.
    //Implement methods for adding a book, removing a book, and displaying
    //the list of books with their details. Ensure that the system handles the scenario
    //where multiple books share the same title but have different ISBNs.
    //Write a program to demonstrate the functionality of your library management system.

    class Author
    {
        string Authorname { get; set; }
        public Author(string Authorname)
        {
            this.Authorname = Authorname;
        }
    }

    class Book
    {
        public string Title { get; set; }
        public string ISBM { get; set; }
        public string reference { get; set; }

        public Book(string Title, string ISBM, Author author)
        {
            this.Title = Title;
            this.ISBM = ISBM;
            this.reference = reference;
        }
        public override string ToString()
        {
            return "title" + Title + "ISBM" + ISBM + "refernce" + reference;
        }
    }
    class library
    {
        List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine("books added" + book);
        }
        public void RemoveBook(string ISBM)
        {
            Book bookToRemove = null;
            foreach (var book in books)
            {
                if (book.ISBM == ISBM)
                {
                    bookToRemove = book;
                    break;
                }
            }
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
                Console.WriteLine("books removed" + bookToRemove);
            }
            else
            {
                Console.WriteLine("books not found in library");
            }
        }

            public void displaybook()
            {
                Console.WriteLine("book in library");

                foreach (var book in books)
                {
                    Console.WriteLine(book);


                }
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
           //create authors
           Author author1=new Author("priyanka");
            Author author2 = new Author("shreya");
            // create books
            Book book1 = new Book("subtile art ", "8921", author1);
            Book book2 = new Book("inside out", "8925", author2);
            Book book3 = new Book("rafta rafta", "3090", author1);
            //create library
            library lib = new library();

             
            //add books to library
            lib.AddBook(book1);
            lib.AddBook(book2);
            lib.AddBook(book3);
            //displaying book
            lib.displaybook();
            //remove book
            lib.RemoveBook("32344");

            //displaying
            lib.displaybook();


            Console.ReadKey();
            }
        }
    }

