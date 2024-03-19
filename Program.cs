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

        List<Bird> moreBirds = new();

        // Fråga 3.4.9. Eftersom horse inte ärver ifrån Bird kan man inte lägga till Horse till listan. 
        // Fråga 3.4.10. Den minsta gemensamma nämnaren för alla klasser är Animal, vilket kräver att listan ska ta Animal för att alla klasser ska kunna läggas till i den. 

        foreach (Animal animal in animals)
        {
            /*
             * Fråga 3.4.13. 
             * 
             * varje iteration i foreach-slingan anropar metoden DoSound() för den specifika instansen av animal. om DoSound inte skulle vara implementerad för just den klassen anropas DoSound i den klassen som den aktuella typen ärver ifrån.
             * Med andra ord kan man säga att varje djur gör sitt eget unika ljud baserat på sin typ och eventuella specialiserade implementationer av DoSound(). Detta gör det möjligt att hantera olika djurarter på ett flexibelt sätt i koden.
             * 
             */
            animal.DoSound();

            Console.WriteLine(animal.Stats());
            //Console.WriteLine(animal.Scratch());

            /* Fråga 3.4.17. 
             * 
             * För att ett animal ska kunna använda metoden Scratch krävs det att det är en Dog, eller ärver ifrån Dog. 
             * För att eventuellt kunna använda scratch med 
             * 
             */
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
