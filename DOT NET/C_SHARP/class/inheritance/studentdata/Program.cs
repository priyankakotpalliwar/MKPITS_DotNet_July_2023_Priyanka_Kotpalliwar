using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentdata
{
    class student
    {
        public string name;
        public string address;

        public void getstudentdata(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public void studentdisplay() {

            Console.WriteLine("name -" + name);
            Console.WriteLine("address - "+ address);
        
        }
    }
    class person:student
    {
        public int age;
        public int rollno;

        public void persontdata(int age, int rollno)
        {
            this.age = age;
                this.rollno = rollno;
        }
        public void persondisplay()
        {
            Console.WriteLine("age " + age);
            Console.WriteLine("roll no " + rollno);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            person data = new person();
            data.getstudentdata("priyanka", "mumbai");
            data.persontdata(11, 21);
            data.studentdisplay();
            data.persondisplay();
            Console.ReadKey();


        }
    }
}
