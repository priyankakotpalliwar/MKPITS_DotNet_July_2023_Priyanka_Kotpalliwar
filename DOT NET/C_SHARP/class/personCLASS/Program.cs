using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace personCLASS
{
    internal class Program
    {
        class person
        {
            string name;
            int age;
            string addres;


            public void getdata(string name, int age, string addres)
            {
               this.name = name;
                 this.age = age;
                this.addres = addres;
            }
            public void display()
            {
                Console.WriteLine("                                                     personal info ");
                Console.WriteLine("name " + name);
                Console.WriteLine("ade "+age);
                Console.WriteLine("address  " + addres);

            }

        }
        static void Main(string[] args)
        {
            person per=new person();
            per.getdata("priyanka", 21, "mohan nagar tent line");
            per.display();
            Console.ReadKey();
        }
    }
}
