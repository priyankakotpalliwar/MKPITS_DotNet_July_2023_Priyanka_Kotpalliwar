using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classEMPLOYEE_ASSIGNMENT_
{
    public class person
    {
        public string name;
        public string address;
    }
    public class Employee:person {

        public int empno;
        public int salary;
        public string designation;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.name = "supriya";
            emp.address = "mumbai";
            emp.salary = 100;
            emp.empno = 2;
            emp.designation = "manager";
            Console.WriteLine(" name - " +emp.name);
            Console.WriteLine("address - "+emp.address);
            Console.WriteLine("employee no - "+emp.empno);
            Console.WriteLine("salary - " + emp.salary);
            Console.WriteLine("designation -" + emp.designation);
            Console.ReadKey();

        }

    }
}
