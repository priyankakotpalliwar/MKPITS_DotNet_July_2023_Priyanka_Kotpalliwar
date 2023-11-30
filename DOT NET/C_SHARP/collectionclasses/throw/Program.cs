using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @throw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age=0;
            try
            { 
                if(age<18)
                {
                    Console.WriteLine("enter age below 18");
                    age =Convert.ToInt32(Console.ReadLine());
                    throw new Exception("age should be greater or equal to 18");
                }
                else
                {

                }


            }
            catch (Exception ex) { 
                Console.WriteLine(ex.ToString());
                Console.WriteLine("enter age greater than 18 ");
                age =Convert.ToInt32(Console.ReadLine());




            }
            finally 
            {
                Console.WriteLine("this will be executed");
                Console.WriteLine("age" + age);

            }
            Console.ReadKey();
        }
    }
}
