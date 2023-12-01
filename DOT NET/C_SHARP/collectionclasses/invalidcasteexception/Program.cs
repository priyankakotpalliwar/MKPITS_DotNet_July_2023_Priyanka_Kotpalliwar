using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invalidcasteexception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("amitab");
            sb.Append("bachan");
            Console.WriteLine(sb.ToString());
            object obj = sb;
            Console.WriteLine(obj.ToString());
            try

            {
                System.IO.StreamReader sr = (System.IO.StreamReader)obj;
            }
            catch(InvalidCastException ee)
            {
                Console.WriteLine(ee.ToString());
            }
            Console.ReadKey();
        }
    }
}
