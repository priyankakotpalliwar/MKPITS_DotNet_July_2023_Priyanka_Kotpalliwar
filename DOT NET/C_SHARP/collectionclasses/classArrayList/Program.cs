using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classArrayList
{
    class student
    {
        public int rollno;
        public string name;
        public student(int rollno,string name)
        {
            this.rollno = rollno;
            this.name = name;
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student(12,"amit");
            student s2 = new student(13, "shreya");
            student s3 = new student(14, "shriwas");

            ArrayList al = new ArrayList();
            al.Add(s1);
            al.Add(s2);
              al.Add(s3);
            //displaying the values of student
            foreach(student s in al)
            {
                Console.WriteLine("roll no "+s.rollno);
                Console.WriteLine("name "+ s.name);
                
            }
            Console.ReadKey();

        }
    }
}
