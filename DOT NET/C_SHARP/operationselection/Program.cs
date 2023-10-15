using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace operationselection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2 ,total;
            string choice;
            
            Console.WriteLine("enter the num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the num2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" 1-Addition.\r\n2-Substraction.\r\n3-Multiplication.\r\n4-Division.\r\n5-Exit.\r\n");
            Console.WriteLine("input your choice");
            choice=Convert.ToString(Console.ReadLine());    
            if(choice == "1" )
            {
                total = num1 + num2;
                Console.WriteLine("the addition of two number are" + total);
            }
            else if(choice== "2")
                { 
                total = num1 - num2;
                Console.WriteLine("the substraction of two number " + total);
            }
            else if( choice== "3") 
            {
                total = num1 * num2;
                Console.WriteLine("the multiplication of two number is " + total);

            }
            else if (choice== "4")
            {
                total = num1 / num2;
                Console.WriteLine("the division of two number  is " + total);
            }
            else
            {
                Console.WriteLine("exit");
            }
            Console.ReadKey();

        }
    }
}
