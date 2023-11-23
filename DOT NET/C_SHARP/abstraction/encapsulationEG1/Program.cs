using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulationEG1
{
    class Employee
    {
        public string employeename { get; set; } 
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.employeename ="savi";//this will call setter 
            Console.WriteLine("employee name " + emp.employeename);
            Console.ReadKey();

        }
    }
}
