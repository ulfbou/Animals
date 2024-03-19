namespace Animals;

/// <summary>
/// Represents a dog, a type of animal.
/// </summary>
internal class Dog : Animal
{
    /// <summary>
    /// Gets or sets a value indicating whether the dog is house trained. 
    /// </summary>
    public bool IsHouseTrained { get; internal set; }

    /// <summary>
    /// Constructs a new instance of the Dog class.
    /// </summary>
    /// <param name="name">The name of the dog.</param>
    /// <param name="weight">The weight of the dog.</param>
    /// <param name="age">The age of the dog.</param>
    /// <param name="habitat">The habitat of the dog.</param>
    /// <param name="isHouseTrained">A value indicating whether the dog is house trained. Defaults to false.</param>
    /// <exception cref="ArgumentException">Thrown when the name or habitat is empty or null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when weight is non-positive or the age is negative.</exception>
    public Dog(string name, double weight, int age, string habitat, bool isHouseTrained = false) : base(name, weight, age, habitat)
    {
        IsHouseTrained = isHouseTrained;
    }

    /// <summary>
    /// Simulates the action of a dog scratching.
    /// </summary>
    /// <returns>A string representing the dog scratching.</returns>
    public string Scratch() => "Scratch!";

    /// <summary>
    /// Produces the characteristic sound of the dog.
    /// </summary>
    public override void DoSound()
    {
        Console.WriteLine($"{Name} the whimsical dog enthusiastically barks, 'Woof-woof! Let's play fetch!'");
    }

    /// <summary>
    /// Provides statistics about the dog.
    /// </summary>
    /// <returns>Statistics string.</returns>
    public override string Stats()
    {
        return $"Is {Name} house trained={IsHouseTrained}";
    }
}
