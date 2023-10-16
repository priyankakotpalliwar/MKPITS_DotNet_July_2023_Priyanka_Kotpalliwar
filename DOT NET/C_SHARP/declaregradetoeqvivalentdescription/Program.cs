using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace declaregradetoeqvivalentdescription
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string grade;
            Console.WriteLine("enter the  grade you wanna know the description");
            grade= Convert.ToString(Console.ReadLine());
            if(grade=="a")
            {
                Console.WriteLine("description= Average");
            }
            else if(grade=="e") 
                {
                Console.WriteLine("description= Excellent");
            }
            else if(grade=="f")
            {
                Console.WriteLine("fail");            
            }
            else if(grade=="G")
            {
                Console.WriteLine(" description=good");


            }
            else if(grade=="v")
            {
                Console.WriteLine("description= very good");
            }
            else
            {
                Console.WriteLine("the grade given is not defined");
            }
            Console.ReadKey();
        }

    }
}
