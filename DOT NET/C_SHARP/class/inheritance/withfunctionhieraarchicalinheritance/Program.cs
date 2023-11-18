using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace withfunctionhieraarchicalinheritance
{
    class person
    {
        string name;
        int  age;
        public void getdataperson(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        public void displaydataperson()
        {
            Console.WriteLine("name - " + name);
            Console.WriteLine("age - " + age);

        }


    }
    class student:person
    {
        string school;
        string address;
        public void getdatastudent(string school,string address)
        {
                this.school = school;
            this.address = address;
        }
        public void displaydatastudent()
        {
            Console.WriteLine("school - "+school);
            Console.WriteLine("address - " + address);

        }
    }
    class employee:person
    {
        string company;
        int salary;
        public void getdataemployee(string company,int salary)
        {
            this.company = company;
            this.salary = salary;
        }
        public  void displaydataemployee()
        {
            Console.WriteLine("company - "+company);
            Console.WriteLine(" salary - " + salary);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1= new student();
            Console.WriteLine("\t\t student details");
            s1.getdataperson("sherya", 12);
            s1.getdatastudent("schollar scholl", "shivnari");
            s1.displaydataperson();
            s1.displaydatastudent();


            employee e1= new employee();
            Console.WriteLine("\t employee details");
            e1.getdataperson("ojefa", 25);
            e1.getdataemployee("swift", 25000);
            e1.displaydataperson();
            e1.displaydataemployee();
            Console.ReadKey();
        }
    }
}
