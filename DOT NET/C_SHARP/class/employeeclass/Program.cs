using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeclass
{
    internal class Program
    {
        class employee
        {
            int employee_no;
            string employee_name;
            string designation;
            int salary;

            public void getdata(int empno, string empname, string desg, int sal)
            {
                employee_no = empno;
                employee_name = empname;
                designation = desg;
                salary = sal;


            }
            public void displaydata()
            {
                Console.WriteLine("employee no " + employee_no);
                Console.WriteLine("\nemployee name " + employee_name);
                Console.WriteLine("\ndesignation " + designation);
                Console.WriteLine("\nsalary " + salary);
            }
        }
        static void Main(string[] args)
        {
            employee emp= new employee();
            emp.getdata(123, "ajay", "clerk", 5000);
            emp.displaydata();
            Console.ReadKey();
        }
    }
}
