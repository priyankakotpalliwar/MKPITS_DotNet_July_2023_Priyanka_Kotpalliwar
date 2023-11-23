using first;
using second;
using System;
namespace first
{
    public class hou
    {
public void hello() {
            Console.WriteLine("hello from first class");
        }
    }
}
namespace second
{
    public class welcome
    {
        public void hello() { Console.WriteLine("hello from second  class"); }







    }
}


namespace namespacewithoutkeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            hou h1 = new hou();
            h1.hello();
            welcome w1= new welcome();
            w1.hello();
            Console.ReadKey();
        }
    }
}
