using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singlelevelInheritance
{
    internal class Program
    {
        class Employee
        {
             public int salary;
        }
        class bonus:Employee
        {
             public int bonous;
        }
        static void Main(string[] args)
        {
            bonus bon = new bonus();
            bon.salary = 10000;
            bon.bonous = 5000;
            Console.WriteLine("salary  - " + bon.salary);
            Console.WriteLine("bonus - " + bon.bonous);
            Console.ReadKey
                ();
        }
    }
}
