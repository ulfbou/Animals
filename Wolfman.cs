namespace Animals;

/// <summary>
/// Represents a wolfman, a hybrid between a wolf and a person.
/// </summary>
internal class Wolfman : Wolf, IPerson 
{
    /// <summary>
    /// Constructs a new instance of the Wolfman class.
    /// </summary>
    /// <param name="name">The name of the wolfman.</param>
    /// <param name="weight">The weight of the wolfman.</param>
    /// <param name="age">The age of the wolfman.</param>
    /// <param name="habitat">The habitat of the wolfman.</param>
    /// <param name="howlingFrequency">The howling frequency of the wolfman. Defaults to 0.75.</param>
    /// <exception cref="ArgumentException">Thrown when the name or habitat is empty or null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the weight is non-positive or the age is negative.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the weight is non-positive, the age is negative or the howling frequency is not within the range [0, 1].</exception>
    public Wolfman(string name, double weight, int age, string habitat, double howlingFrequency = 0.75) : base(name, weight, age, habitat, howlingFrequency) {}

    /// <summary>
    /// Produces the characteristic sound of the wolfman.
    /// </summary>
    public override void DoSound()
    {
        Console.WriteLine($"Underneath the moon's embrace, {Name} the wolfman serenades the night with a howl that dances between eerie and endearing.");
    }

    // Implements the interface of IPerson.

    /// <summary>
    /// Makes the wolfman talk with the specified message.
    /// </summary>
    /// <param name="message">The message to be spoken by the wolfman.</param>
    public void Talk(string message)
    {
        Console.WriteLine($"{Name} says sternly, '{message}'");
    }
}
