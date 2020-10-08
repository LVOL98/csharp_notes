using System;

namespace Inheritance
{
    public abstract class Animal
    {
        public static int population { get; set; }
        public string name = "Animal";

        public Animal()
        {
            population++;
        }

        // TODO Why do we need a get method, once the field is static?
        public int GetCurrentPopulation()
        {
            return population;
        }

        public void ResetCurrentPopulation()
        {
            population = 0;
        }

        public abstract string Sound();

        public override string ToString()
        {
            return $"I'm a: {name}";
        }
    }

    public class Dog : Animal
    {
        public Dog()
        {
            name = "Dog";
        }

        public override string Sound()
        {
            return "Woof";
        }
    }

    public class Cat : Animal
    {
        public override string Sound()
        {
            return "Miaw";
        }
    }
}