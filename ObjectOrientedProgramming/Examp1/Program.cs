using System;

namespace Examp1
{
    class Animal
    {
        protected double Weight;
        protected double Height;
        protected static int Legs;
        public void Info()
        {
            Console.WriteLine("Weight: " + Weight + " Height: " + Height + " Legs: " + Legs);
        }
    }
    class Cat : Animal
    {
        public Cat ()
        {
            Weight = 500;
            Height = 20;
            Legs = 2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat BlackCat = new Cat();
            BlackCat.Info();
            Console.ReadKey();
        }
    }
}
