using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multievelinheritance
{
    class animal
    {
        public void eating()
        {
            Console.WriteLine(" eating the food");
        }

    }
    class dog:animal
    {
        public void barking()
        {
            Console.WriteLine("barking on street");

        }
    }
    class puppy : dog
    {
        public void weep()
        {
            Console.WriteLine("puppy is cuteee");
        }

    }
        internal class Program
        {
            static void Main(string[] args)
            {
            puppy pu=new puppy();
            pu.eating();
            pu.barking();
            pu.weep();
            Console.ReadKey();
            }
        }
    }
