using System;
using factoryPattern.Animals;
using factoryPattern.Factory;

namespace factoryPattern {
    class Program {
        static void Main (string[] args) {
            AnimalFactory factory = new AnimalFactory ();
            Animal dog = factory.GetAnimal ("dog");
            Console.WriteLine (dog.Eat ());
            Animal cat = factory.GetAnimal ("cat");
            Console.WriteLine (cat.Eat ());
            Animal elephant = factory.GetAnimal ("elephant");
            Console.WriteLine (elephant.Eat ());
        }
    }
}