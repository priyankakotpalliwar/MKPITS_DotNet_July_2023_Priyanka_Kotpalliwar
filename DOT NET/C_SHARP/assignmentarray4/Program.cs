using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentarray4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]arr=new int[3];
            int []arr1= new int[3];
            
            for (int i = 0; i <3; i++)
            {
                Console.WriteLine("enter the number");
                arr[i] = Convert.ToInt32(Console.ReadLine());

                
            }
            
            for (int i = 0; i < 3; i++)
            {
                arr1[i] = arr[i];
            }
            for (int i = 0; i < 3; i++)
            {
                Console.Write(arr1[i]+"\t");



            }

            Console.ReadKey(); 
        }
    }
}
