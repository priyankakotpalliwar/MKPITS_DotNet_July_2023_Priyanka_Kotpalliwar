using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace classStudent
{
    internal class Program
    {
        class student
        {
            string name;
            int rollno;
            int[]marks =new int[3];
            int avg;


            public void getdata(string name,int rollno,int[]marks)
            {

                this.name = name;
                this.rollno = rollno;
                this.marks = marks;
                int total = 0;
                for (int i = 0; i < this.marks.Length; i++)
                {
                    total =total+ marks[i];
                }
                avg = total/this.marks.Length;


            }
            public void displaydata()
            {
                Console.WriteLine("name" + name);
                Console.WriteLine("roll no" + rollno);
                Console.WriteLine(" avg" + avg);
            }
        }
        static void Main(string[] args)

        {
            int[] ma = { 33, 44, 55 };
            student s1= new student();
            s1.getdata("priyanka", 21, ma);
            s1.displaydata();
            Console.ReadKey();
        }
    }
}
