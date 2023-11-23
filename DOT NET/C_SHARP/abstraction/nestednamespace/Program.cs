using System;
using first;
using first.second;
namespace first
{
    public class hello
    {
        public void hi()
        {
            Console.WriteLine("hello from first class");
        }
    }

    namespace second
    {
        public class namastay
        {
            public void fine()
            {
                Console.WriteLine("hello from second class");
            }
        }
    }

    namespace nestednamespace
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                hello h1 = new hello();
                namastay n2 = new namastay();
                h1.hi();
                n2.fine ();
                Console.ReadKey();
            }
        }
    }
}
