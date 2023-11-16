using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectedSingleLevelInheritance
{
    class Employee
    {
      protected  int salary;
    }
    class programmer:Employee
    {

        int bonus;

        public void getdata(int salary,int bonus)
        {
            this.salary = salary;
            this.bonus = bonus;
        }
        public void display()
        {
            Console.WriteLine("  salary   of the employee is "+salary);
            Console.WriteLine("Bonus of the Employee is "+bonus);
        }
        

    
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            programmer po = new programmer();
            po.getdata(10000, 5000);
            po.display();
            Console.ReadKey();
        }
    }
}
