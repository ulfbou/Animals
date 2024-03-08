using System;

namespace Animals;

internal class Program
{
    static void Main(string[] args)
    {
        // Create one instance of each subclass of Animal. 
        Bird bird = new Bird("Larry", 3, 8, "Forest", 20);
        Dog dog = new Dog("Dogy", 25, 10, "Urban apartments");
        Flamingo flamingo = new Flamingo("Flamy", 97, 13, "Coastal areas with brackish water");
        Hedgehog hedgehog = new Hedgehog("Hedgy", 2, 1, "Forest edges");
        Horse horse = new Horse("Horsy", 100, 7, "Grasslands");
        Pelican pelican = new Pelican("Pelly", 5, 18, "Coastal wetlands");
        Swan swan = new Swan("Swany", 65, 22, "Freshwater lakes");
        Wolf wolf = new Wolf("Wolfy", 45, 9, "Open tundra");
        Worm worm = new Worm("Wormy", 0.25, 0, "Compost heap");
        Wolfman wolfman = new Wolfman("Manny", 209, 110, "Rural areas");

        dog.Scratch();


        List<Animal> animals = new List<Animal>
        {
            bird, worm, flamingo, swan, wolfman, hedgehog, dog, horse, wolf,pelican
        };

        List<Bird> birds = new();

        //Fråga 9. Både Horse och Bird är Animal, men eftersom Bird inte är en Horse kan den inte använda sig av Horse metod. 
        //Fråga 10. Animal

        foreach (Animal animal in animals)
        {
            animal.DoSound();
            Console.WriteLine(animal.Stats());
            //Console.WriteLine(animal.Scratch());
            // Fråga 17: Inte alla Animal är en Dog. 

            if (animal is IPerson)
            {
                IPerson person = (IPerson)animal;

                person.Talk("Not only can I make sounds. I can also talk!");
            }

            if (animal is Dog)
            {
                Dog dog1 = (Dog)animal;

                Console.WriteLine(dog1.Scratch());
            }
        }
    }
}
