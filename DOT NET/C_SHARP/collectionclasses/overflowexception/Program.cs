using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overflowexception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            try
            {
                
                
                    Console.WriteLine("enter the age");
                    age = Convert.ToInt32(Console.ReadLine());
                    if(age<18)
                {
                    Console.WriteLine("age should be greater than 18 or equal to 18");

                }
                
            }
            catch(OverflowException ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("enter small number");
                age= Convert.ToInt32(Console.ReadLine());
                
            
            } 
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("enter small number");
                age = Convert.ToInt32(Console.ReadLine());

            }
            finally
            {
                Console.WriteLine("finally block is excuting");
                Console.WriteLine("age   "+ age);
            }
            Console.ReadKey();
        }
       
    }
}
