using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexoutofrange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
                arr[0] = 33;
            arr[1] = 44;
            arr[2] = 55;
            try
            {
                for (int i = 0; i <= 3; i++)
                {

                    Console.WriteLine(arr[i]);
                }
            }
            catch (IndexOutOfRangeException eyy)
            { 
                Console.WriteLine(eyy.ToString());
            }
            finally
            {
                Console.WriteLine("One execution");
            }

            Console.ReadKey();
        }
    }
}
