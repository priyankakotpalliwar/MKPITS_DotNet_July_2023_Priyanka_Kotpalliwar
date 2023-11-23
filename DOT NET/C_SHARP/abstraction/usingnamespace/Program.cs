using System;
using System.Collections.Generic;

using first;
using second;
namespace first
{
    public class hello
    {
        public void sayhello()
        {

            Console.WriteLine("hello from first namespace");
        }
    }

}
namespace second
{

    public class welcome
    {
        public void sayhi() { Console.WriteLine(" welcome from second class"); }
    }
}

namespace usingnamespace
{
    
    
    internal class Program
    {
        static void Main(string[] args)
        {
            hello h1= new hello();
            welcome we = new welcome();
            h1.sayhello();
            we.sayhi();
            Console.ReadKey();
        }
    }
}
