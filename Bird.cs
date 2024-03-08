using Animals;

/// <summary>
/// Represents a bird, a type of animal.
/// </summary>
internal class Bird : Animal
{
    private double wingspan;

    // Fråga 3.3.13. Ett nytt attribut för alla fåglar här är lämpligt att lägga här. 

    /// <summary>
    /// Gets or sets the wingspan of the bird.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the wingspan is set to a non-positive value.</exception>
    public double Wingspan
    {
        get => wingspan;
        internal set
        {
            ValidateWingspan(value);
            wingspan = value;
        }
    }

    // Fråga 13: Det är lämpligt att lägga ett attribut som är gemensamt för alla fåglar här. 

    /// <summary>
    /// Constructs a new instance of Bird class.
    /// </summary>
    /// <param name="name">The name of the bird.</param>
    /// <param name="weight">The weight of the bird.</param>
    /// <param name="age">The age of the bird.</param>
    /// <param name="habitat">The habitat of the bird.</param>
    /// <param name="wingspan">The wingspan of the bird.</param>
    /// <exception cref="ArgumentException">Thrown when the name or habitat is empty or null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the weight or wingspan is non-positive or the age is negative.</exception>
    public Bird(string name, double weight, int age, string habitat, double wingspan) : base(name, weight, age, habitat)
    {
        ValidateWingspan(wingspan);
        Wingspan = wingspan;
    }

    /// <summary>
    /// Validates the wingspan of the animal.
    /// </summary>
    /// <param name="wingspan">The wingspan to validate.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the wingspan is non-positive.</exception>
    protected void ValidateWingspan(double wingspan)
    {
        if (wingspan <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(wingspan), "Wingspan must be positive.");
        }
    }

    /// <summary>
    /// Produces the characteristic sound of the bird.
    /// </summary>
    public override void DoSound()
    {
        Console.WriteLine($"{Name} the graceful bird sings, \"Tweet-tweet!\"");
    }

    /// <summary>
    /// Provides statistics about the bird.
    /// </summary>
    /// <returns>Statistics string.</returns>
    public override string Stats()
    {
        return $"Wingspan={Wingspan}";
    }
}
