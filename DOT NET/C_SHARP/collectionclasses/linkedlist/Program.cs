using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exampleoflinklist


{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> lk = new LinkedList<int>();
            lk.AddLast(1);
            lk.AddLast(8);
            lk.AddLast(4);
            lk.AddLast(7);
            lk.AddLast(2);
            lk.AddFirst(11);
            lk.AddFirst(12);

            LinkedListNode<int> node = lk.Find(11);
            lk.AddBefore(node, 3);
            foreach (int i in lk)
            {
                Console.WriteLine
                    (i);
            }
            Console.ReadKey();
        }
    }
}
