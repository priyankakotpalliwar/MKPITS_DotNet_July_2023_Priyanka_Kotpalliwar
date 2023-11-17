using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parttimeemployee
{
    class person
    {
        string name;
        string address;
        public void getdata(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public void display()
        {
            Console.WriteLine("name of the employee"+name);
            Console.WriteLine("addres of employee"+address);

        }
    }
    class employee:person
    {
        int salary;
        string designation;
        public void getdataemployee(int salary, string designation)
        {
            this.salary = salary;
                this.designation = designation;
           
        }
        public void displaydataemployee()
        {
            Console.WriteLine("salary is "+salary);
            Console.WriteLine("designation is " + designation);
        }

    }
    class partimeemployee:employee
    {
        int hoursofworking;
        int bonus;
        public void getdatapart(int hoursofworking,int bonus)
        {
            this.hoursofworking = hoursofworking;
            this.bonus = bonus;

        }
        public void displaydatapart()
        {
            Console.WriteLine("hours  of working "+ hoursofworking);
            Console.WriteLine("bonus given " + bonus);

        }
    }
    class febonaci:partimeemployee
    {
        string book;
        public void bookin()
        {
            Console.WriteLine("this is book");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            febonaci f1 = new febonaci();
            f1.getdata("priyanka", "mumbai");
            f1.getdataemployee(20000, "manager");
            f1.getdatapart(5, 9000);
            f1.display();
            f1.displaydataemployee();
            f1.displaydatapart();
            f1.bookin();
            Console.ReadKey();
        }
    }
}
