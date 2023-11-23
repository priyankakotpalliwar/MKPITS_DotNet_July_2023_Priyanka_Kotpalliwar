using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace encapsulationeg2
{
    class student
    {
        public int id { get; set; }
        public string name { get; set; }
        public string mailid { get; set; }
        internal class Program
        {
            static void Main(string[] args)
            {
                student s1 = new student();
                //seting values to the properties
                s1.id = 1;
                s1.name = "saviyan";
                s1.mailid = "huzefa@gmail.com";
                // getting values
                Console.WriteLine("id = "+s1.id);
                Console.WriteLine("name = "+s1.name);
                Console.WriteLine("mailid = "+s1.mailid);
                Console.ReadKey();
            }
        }
    }
}
