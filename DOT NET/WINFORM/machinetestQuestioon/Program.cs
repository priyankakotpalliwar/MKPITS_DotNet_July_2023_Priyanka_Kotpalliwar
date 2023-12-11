using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace machinetestQuestioon
{
    class Animal
    {
        public string name;
        public int age;
        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public virtual void Makesound()
        {
            Console.WriteLine("thiss is sound");

        }
    }
    class Mammal : Animal
    {
        public Mammal(string name, int age) : base(name, age)
        {
        }
    }
    class Reptile : Animal
    {
        public Reptile(string name, int age) : base(name, age)
        {
        }
    }
    class Bird : Animal
    {
        public Bird(string name, int age) : base(name, age)
        {
        }
    }
    class Lion : Mammal
    {
        public Lion(string name, int age) : base(name, age)
        {

        }
        public override void Makesound()
        {
            Console.WriteLine("roarrr");
        }
    }
    class Snake :Reptile
        {
        public Snake(string name, int age):base(name, age)
        {
            

        }
        public override void Makesound()
        {
            Console.WriteLine("hiss");
        }

    }
    class Eagle:Bird
    {
        public Eagle(string name,int age):base(name, age)
        {

        }
        public override void Makesound()
        {
            Console.WriteLine("crurr");
        }
    }
    internal class Program
    {
       
        static void Main(string[] args)
        {
            //Design a class hierarchy for a zoo simulation in C#.
            //Consider having base classes for animals, such as Mammal, Reptile, and Bird.
            //Implement specific derived classes for animals like Lion, Snake, and Eagle.
            //Each animal should have common properties like Name, Age, and a method for making a sound.
            //Additionally, implement methods or properties specific to each animal type.
            //Create instances of these classes and demonstrate polymorphism by
            //calling the common methods on objects of different derived classes.


            Lion li = new Lion("simbha", 3);
            Snake snake = new Snake("nagin", 9);
            Eagle eagle = new Eagle("shumshera", 8);
            Animal[]an= {li, snake,eagle};
            foreach(var animal in an )
            {
                Console.WriteLine("name" + animal.name + "age " + animal.age);
                animal.Makesound();


            }
            Console.ReadKey();


        }
    }
}
