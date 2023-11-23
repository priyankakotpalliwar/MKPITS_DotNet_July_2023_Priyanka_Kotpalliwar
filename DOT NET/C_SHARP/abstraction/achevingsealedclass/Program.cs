using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace achevingsealedclass
{
    abstract class person
    {
        public string name;
    }
    class student:person { 
    public int rollno;}
     sealed class college:student
    {
        public string collegename;
    }
     
    

    
    internal class Program
    {
        static void Main(string[] args)
        {
          college c1= new college();
            c1.name = "piya";
            c1.rollno = 21;
            c1.collegename = "raisoni";
            Console.WriteLine("name is "+c1.name);
            Console.WriteLine("roll no is "+ c1.rollno);
            Console.WriteLine("college name is " + c1.collegename);
            Console.ReadKey();
        }
    }
}
