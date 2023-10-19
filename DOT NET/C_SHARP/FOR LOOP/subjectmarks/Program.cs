using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;

namespace subjectmarks
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // wap to accept 5 subject marks using for loop
//calculate total, per and grade

            int marks;
            int total=0;
            int per = 0;
            
            int i;
            {
                for(i=1;i<=3;i++)
                {
                    Console.WriteLine("enter three subject marks");
                    marks=Convert.ToInt32(Console.ReadLine());
                    total = total + marks;
                }
                Console.WriteLine(" total = " + total);
                per = total / 3;
                Console.WriteLine(" percentange " + per);
                if(per>=75)
                {
                    Console.WriteLine(" GRADE = A");
                }
                else if(per>=50 && per<=75)
                {
                    Console.WriteLine(" GRADE = B");

                }
                else if(per>=35 && per<=50)
                {
                    Console.WriteLine(" GRADE =C");

                }
                else
                {
                    Console.WriteLine(" GRADE =F");
                }


            }
            Console.ReadKey();
        }
    }
}
