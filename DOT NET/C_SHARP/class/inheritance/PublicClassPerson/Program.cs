using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicClassPerson
{
     public class Person
    {
       public string name;
     public   string address;

    }
    public class student:Person
    {
       public  int rno;
       public int marks;
    }
    class testinheritance

    {
        static void Main(string[] args)
        {
            student s1 = new student();//creating object of derived class
            s1.name = "priyanka";
            s1.address = "mohan nagar, nagpur";
            s1.rno= 1;
            s1.marks = 75;
            Console.WriteLine("\t\t\t\t\tstudent details ");
            Console.WriteLine("\tname  - "+s1.name);
            Console.WriteLine("\taddress -  "+s1.address);
            Console.WriteLine("\trno "+s1.rno);
            Console.WriteLine("\tmarks " + s1.marks);

            Console.ReadKey();

        }
    }
}
