using System;

namespace printsquareofnumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sqauare;
            Console.WriteLine("enter the number");
            num=Convert.ToInt32(Console.ReadLine());
            sqauare = num * num;
            Console.WriteLine("sqauare="+sqauare);
            Console.ReadKey();
        }
    }
}
