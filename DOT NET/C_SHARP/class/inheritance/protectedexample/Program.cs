using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protectedexample
{
     class person
    {
       string name;
        protected void getdata(string name)
        {
            this.name = name;
        }

    }
    class employee :person

    {
        int salary;
        int bonous;
        internal void getdataemployee(int salary, int bonous)
        { 
            this.salary= salary;
            this.bonous= bonous;

        }
        internal void displaydata()
        {
            Console.WriteLine("salary is " + salary);
            Console.WriteLine("bonus " + bonous);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee emp = new employee();
            emp.getdataemployee(100000, 1000);
            emp.displaydata();
           
            Console.ReadKey();

        }
    }
}
