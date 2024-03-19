namespace Animals;

/// <summary>
/// Represents a hedgehog, a type of animal.
/// </summary>
internal class Hedgehog : Animal
{
    /// <summary>
    /// Gets or sets a value indicating whether the hedgehog is nocturnal.
    /// </summary>
    public bool IsNocturnal { get; internal set; } 

    /// <summary>
    /// Constructs a new instance of the Hedgehog class.
    /// </summary>
    /// <param name="name">The name of the hedgehog.</param>
    /// <param name="weight">The weight of the hedgehog.</param>
    /// <param name="age">The age of the hedgehog.</param>
    /// <param name="habitat">The habitat of the hedgehog.</param>
    /// <param name="isNocturnal">A value indicating whether the hedgehog is nocturnal. Defaults to true.</param>
    /// <exception cref="ArgumentException">Thrown when the name or habitat is empty or null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when weight is non-positive or the age is negative.</exception>
    public Hedgehog(string name, double weight, int age, string habitat, bool isNocturnal = true) : base(name, weight, age, habitat)
    {
        IsNocturnal = isNocturnal;
    }

    /// <summary>
    /// Produces the characteristic sound of the hedgehog.
    /// </summary>
    public override void DoSound()
    {
        Console.WriteLine($"{Name} the adorable hedgehog makes soft grunting sounds.");
    }

    /// <summary>
    /// Provides statistics about the hedgehog.
    /// </summary>
    /// <returns>Statistics string.</returns>
    public override string Stats()
    {
        return $"Is {Name} nocturnal={IsNocturnal}";
    }
}
