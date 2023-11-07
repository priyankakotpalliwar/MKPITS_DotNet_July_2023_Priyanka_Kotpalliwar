using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeewithnoparameterandparametrized
{
    internal class Program
    {
        class Employee
        {
            int empno;
            string empname;
            string designation;
            int salary;


            public Employee()
            {
                empno= 1;
                empname = "ashish";
                designation = "clerk";
                salary = 15000;
            }
            public Employee(int empno, string empname, string designation, int salary)
            {
                this.empno = empno;
                this.empname = empname;
                this.designation = designation;
                this.salary = salary;
            }
            public void display()
            {
                Console.WriteLine("emp no " + empno);
                Console.WriteLine("empname " + empname);
                Console.WriteLine("designation "+ designation);
                Console.WriteLine("salary "+ salary);
            }
        }
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.display();

            Employee emp2= new Employee(12,"shreya","manager",9000);
            emp2.display();
            Console.ReadKey();

        }
    }
}
