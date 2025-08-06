using System;
using System.Data;

namespace FunWithLoops
{
    class Program
    {
        public int Number1 = 5;
        Animals animals = new Animals();
        Dog dog = new Dog();
        Cat cat = new Cat();
        
        public static void Main(string[] args)
        {
            int Number5 = 5;
            Console.WriteLine("Entry point into the code!");
            Animals.Live();
            Dog.Live();
            Cat.Live();

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("I'm living! ", Number5);
            }
        }
    }
    class Animals
    {
        public bool isAlive = false;
        public string Organism = "Animal";
        public static void Live()
        {
            Console.WriteLine("I live!");
        }
    }
    class Dog : Animals
    {   
    
    }
    class Cat : Animals
    {

    }
}