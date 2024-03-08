namespace Animals;

/// <summary>
/// Represents a flamingo, a type of bird.
/// </summary>
internal class Flamingo : Bird
{
    private double legLength;

    /// <summary>
    /// Gets or sets the length of the flamingo's legs.
    /// </summary>
    public double LegLength
    {
        get => legLength;
        internal set
        {
            ValidateLegLength(value);
            legLength = value;
        }
    }

    /// <summary>
    /// Constructs a new instance of the Flamingo class.
    /// </summary>
    /// <param name="name">The name of the flamingo.</param>
    /// <param name="weight">The weight of the flamingo.</param>
    /// <param name="age">The age of the flamingo.</param>
    /// <param name="habitat">The habitat of the flamingo.</param>
    /// <param name="wingspan">The wingspan of the flamingo. Defaults to 18.</param>
    /// <param name="legLength">The length of the flamingo's legs. Defaults to 150.</param>
    /// <exception cref="ArgumentException">Thrown when the name or habitat is empty or null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the weight, wingspan of legLength is non-positive or the age is negative.</exception>
    public Flamingo(string name, double weight, int age, string habitat, double wingspan = 18, double legLength = 150) : base(name, weight, age, habitat, wingspan)
    {
        ValidateLegLength(legLength);
        LegLength = legLength;
    }

    /// <summary>
    /// Produces the characteristic sound of the flamingo.
    /// </summary>
    public override void DoSound()
    {
        Console.WriteLine($"{Name} the elegant flamingo clears her throat and announces, ‘Fla-ming-gooo!’ in perfect harmony.");
    }

    /// <summary>
    /// Provides statistics about the flamingo.
    /// </summary>
    /// <returns>Statistics string.</returns>
    public override string Stats()
    {
        return $"{Name}'s leg length={LegLength}";
    }

    // Validation method

    /// <summary>
    /// Validates the leg length of the flamingo.
    /// </summary>
    /// <param name="legLength">The leg length to validate.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the leg length is non-positive.</exception>
    private void ValidateLegLength(double legLength)
    {
        if (legLength <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(legLength), "Leg length must be positive.");
        }
    }

}
