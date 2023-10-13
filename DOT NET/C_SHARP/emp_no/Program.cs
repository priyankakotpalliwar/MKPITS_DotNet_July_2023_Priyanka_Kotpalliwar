using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace emp_no
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int empno, basic_salary;
            float bonus = 0;
            float total_sal;
            string empname,designation;
            Console.WriteLine("enter empno");
            empno=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter employee name");
            empname= Convert.ToString(Console.ReadLine());
            Console.WriteLine("basic salary");
            basic_salary=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the designation");
            designation = Convert.ToString(Console.ReadLine()); 

            if( designation == "manager")
            {
                bonus = basic_salary * 0.55f;
            }
            else if( designation =="clerk")
            {
                bonus = basic_salary* 0.55f;
            }
            else if( designation == "peoun")
            {
                bonus = basic_salary * 0.10f;
            }
            else
            {
                Console.WriteLine("you are not part of company");
                    }

            
            total_sal = basic_salary + bonus;
            Console.WriteLine("emp no:{0}\n empname:{1} \nbasic salary:{2} \n designation:{3} \n total salary:{4}"+ empno + empname + basic_salary + designation + total_sal );
            Console.ReadKey();
        }
    }
}
