using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentarrray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[]arr= new int[3];
            for(int i = 0;i<3;i++)
            {
                Console.WriteLine("ENTER NUMBER");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine(arr[i]);
                sum = sum + arr[i];
                

            }
            Console.WriteLine("sum of the elements stored in the array"+sum);

            Console.ReadKey();
        }
    }
}
