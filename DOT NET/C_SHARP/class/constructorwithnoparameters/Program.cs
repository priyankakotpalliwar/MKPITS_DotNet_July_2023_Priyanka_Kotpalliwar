using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorwithnoparameters
{
    class Employee
    {
        int empno;
        string empname;
        string designation;
        int salary;

        public Employee() {

            empno = 1;
            empname = "priyanka";
            designation = "manger";
            salary = 50000;
        }
        public void display()
        {
            Console.WriteLine("emp no -"+ empno);
            Console.WriteLine("hello"+string.Empty);
            Console.WriteLine("Designation - "+ designation);
            Console.WriteLine("salary  - " + salary);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.display();
            Console.ReadKey();
        }
    }
}
