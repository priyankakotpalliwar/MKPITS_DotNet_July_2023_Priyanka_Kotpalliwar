using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace bankwithinheritance
{
    class account
    {
        public int actno;
        public int bal = 1000;
        public void deposit(int amt)
        {

            Console.WriteLine("ampunt deposited in acc");
        }
    }
    class saving:account
    {
        public void deposit(int amt)

        {
            int interset = 500;
            bal = bal + amt + intrest;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
