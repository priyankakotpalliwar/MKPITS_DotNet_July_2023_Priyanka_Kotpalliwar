using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentarray2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[]arr1=new int[3];
            for(int i=0; i<3; i++)
            {
                Console.WriteLine("enter number");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            for(int i=2; i>=0 ; i--) {
                Console.WriteLine(arr1[i]);
            }
            Console.ReadKey();
        }
    }
}
