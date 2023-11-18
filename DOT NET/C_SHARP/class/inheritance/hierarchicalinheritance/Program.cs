using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hierarchicalinheritance
{
    class person
    {
        public int id;
        public string name;
    }
    class student:person

    {
        public string school;
        public int rollno;
    }
    class employee:person
    {
        internal string company;
        public string designation;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student();
            s1.id=1;
           s1.name = "shreya";
            s1.school = "st.josephs convet";
            s1.rollno = 21  ;
            Console.WriteLine("\t student   details ");
            Console.WriteLine("id- " + s1.id);
            Console.WriteLine(" name- " + s1.name);
            Console.WriteLine("school - " + s1.school);
            Console.WriteLine("roll no - " + s1.rollno);

            employee e1= new employee();
            e1.id=1;
            e1.name = "mala";
            e1.company = "oracle";
            e1.designation = "web developer";
            Console.WriteLine("\t employee details ");
            Console.WriteLine(" id -" + e1.id);
            Console.WriteLine("name - " + e1.name);
            Console.WriteLine(" company - " + e1.company);
            Console.WriteLine("designation - " + e1.designation);
            Console.ReadKey();
        }
    }
}
