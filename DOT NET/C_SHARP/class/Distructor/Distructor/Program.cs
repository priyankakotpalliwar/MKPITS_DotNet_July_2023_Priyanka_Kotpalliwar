using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distructor
{
    internal class Program
    {
        class Employee
        {
            public Employee()
            {
                Console.WriteLine("Constructor called ");

            }
            ~Employee()
            {
                Console.WriteLine("Distructor Called");
            }
        }
        static void Main(string[] args)
        {
            Employee e = new Employee();
            Console.ReadKey();
            Employee e2 = new Employee();

            Console.ReadKey();
        }
    }
}
