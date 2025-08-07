using System;

namespace AbstractionAndLoops
{
    class Program
    {
        public static void Main(string[] args)
        {

        }
    }
    abstract class Food
    {
        public abstract void Decay();
        public float age = 1.5f;
        public bool isSafeToEat = true;
        public void Eat()
        {
            Console.WriteLine("Food eaten");
            isSafeToEat = false;
        }
    }
}