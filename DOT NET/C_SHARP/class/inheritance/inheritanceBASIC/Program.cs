using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceBASIC
{///creating base class
    class Person
    {
        public string name;
    }
    //creating derived class
     class student:Person
    {
         public int rno;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student stu = new student();
            stu.rno = 1;
            stu.name= "shreya";
            Console.WriteLine("name -  "+stu.name);
            Console.WriteLine(" Roll no - " + stu.rno);
            Console.ReadKey();

        }
    }
}
