using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace assignmentCALCULATOR
{
    internal class Program
    {
         public static int addition(int result, int num)
        {

            
            result += num;
            return result;
        }

        static void Main(string[] args)
        {
            int result = 1;
            int num = 2;

            Console.WriteLine("enter the number 2");
            /*result=Convert.ToInt32(Console.ReadLine());
            num= Convert.ToInt32(Console.ReadLine());
            */
            int a=addition(result,num);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
