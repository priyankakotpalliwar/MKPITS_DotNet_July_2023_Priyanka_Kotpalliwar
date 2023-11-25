using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Stackw
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push('m');
            st.Push('e');
            st.Push('f');
            st.Push('l');
            Console.WriteLine("current stack");
            foreach(Char c in st)
            {
                Console.WriteLine(c+"")
                    ;
            }
            Console.ReadKey();
        }
    }
}
