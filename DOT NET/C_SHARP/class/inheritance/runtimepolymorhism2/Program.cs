using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace runtimepolymorhism2
{
    class animal
    {
        public virtual  void show()
        {
            Console.WriteLine("helooo");
        }
    }
    class dog:animal
    {
        public override void show()
        {
            Console.WriteLine("dog bark");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            animal a1=new dog();
            a1.show();
            Console.ReadKey();
        }
    }
}
