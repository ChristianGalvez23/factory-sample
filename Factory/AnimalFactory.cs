using System;
using factoryPattern.Animals;

namespace factoryPattern.Factory {
    public class AnimalFactory {
        public Animal GetAnimal (string animalType) {
            switch (animalType) {
                case "dog":
                    return new Dog ();
                case "cat":
                    return new Cat ();
                case "elephant":
                    return new Elephant ();
            }
            return null;
        }
    }
}