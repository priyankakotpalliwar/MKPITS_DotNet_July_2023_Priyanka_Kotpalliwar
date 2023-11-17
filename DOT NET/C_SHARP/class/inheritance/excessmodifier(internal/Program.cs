using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excessmodifier_internal
{
    public class person
    {
        string name;
        string address;
        internal void getdata(string name,string address)
        {
            this.name=name;
            this.address=address;
        }
        protected internal void displaydata() {

            Console.WriteLine(" name of the student is  " + name);
            Console.WriteLine("address of the student " + address);
        }
    }
    public class student:person
    {
        int rno;
        int marks;
        public void getdatastudent(int rno,int marks)
        {
            this.rno=rno;
            this.marks=marks;

        }
        public void displaydatastudent()
        {
            Console.WriteLine("rno of student is " + rno);
            Console.WriteLine("marks of student is " + marks);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1= new student();
            s1.getdata("priyanka", "mumbai");
            s1.getdatastudent(21, 75);
            s1.displaydata();
            s1.displaydatastudent();

            Console.ReadKey();
        }
    }
}
