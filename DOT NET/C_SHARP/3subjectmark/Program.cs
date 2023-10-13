using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3subjectmark
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // aceept three subject mark and total,per and grade
           int sub1, sub2,sub3,total;
            float per;
            string grade= null;
            Console.WriteLine("enter sub 1");
            sub1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter sub 2");
            sub2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter sub 3");
            sub3 = Convert.ToInt32(Console.ReadLine());
            total= sub1+ sub2+sub3;
            Console.WriteLine("total" + total);
            per = (total / 300.0f) * 100.0f;
            Console.WriteLine("percentange  =" + per);
            if (per >= 75) 
            {
                grade = "distinction";

            }
            else if(per >=60 &&  per < 75)
            {
                grade = "first class";
            }
            else 
            {
                grade = "fail";
                    }
            Console.WriteLine("grade :{0}" + grade);
            Console.ReadKey();

        }
    }
}
