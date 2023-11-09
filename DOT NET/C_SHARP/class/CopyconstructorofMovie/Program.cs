using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyconstructorofMovie
{
    class movie
    {
        int time;
        string moviename;



        public movie() {


            time = 7;
            moviename = "heropanti";
        }
        public movie(movie m1)
        {
            time= m1.time;
            moviename = "pagalpanti";
        }
        public void display()
        {
            Console.WriteLine(" time " + time);
            Console.WriteLine("moviename "+moviename);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
            
        {
            movie mov= new movie();
            movie mov2= new movie();

            Console.WriteLine("movie theater 1 ");
            mov.display();
            Console.WriteLine("movie theater 2 ");
            mov2 .display();
            Console.ReadKey();

        }
    }
}
