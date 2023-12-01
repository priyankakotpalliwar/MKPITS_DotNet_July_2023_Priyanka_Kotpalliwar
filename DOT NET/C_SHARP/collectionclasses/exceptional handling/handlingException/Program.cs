using errorhandlingException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace errorhandlingException
{
    class dividenumber
    {
        int result;
        public dividenumber()
        {
             result = 0;
        }
            public void division(int num1, int num2)
            {
            try
            {
                result = num1 / num2;
            }
            catch(DivideByZeroException ee)  
            { 
                Console.WriteLine("exception caught {0}",ee);
            }
            finally
            {
                Console.WriteLine("Result: {0}",result);
            }
           
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        dividenumber di = new dividenumber();
        di.division(1, 0);
      Console.ReadKey();
        }
    }

