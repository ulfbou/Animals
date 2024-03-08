namespace Animals;

/// <summary>
/// Represents a wolf, a type of animal.
/// </summary>
internal class Wolf : Animal
{
    private double howlingFrequency;

    /// <summary>
    /// Gets or sets the howling frequency of the wolf.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the howling frequency is not within the range [0, 1].</exception>
    internal double HowlingFrequency
    {
        get => howlingFrequency;
        private set
        {
            ValidateHowlingFrequency(value);

            howlingFrequency = value;
        }
    }

    /// <summary>
    /// Constructs a new instance of the Wolf class.
    /// </summary>
    /// <param name="name">The name of the wolf.</param>
    /// <param name="weight">The weight of the wolf.</param>
    /// <param name="age">The age of the wolf.</param>
    /// <param name="habitat">The habitat of the wolf.</param>
    /// <param name="howlingFrequency">The howling frequency of the wolf. Defaults to 0.9.</param>
    /// <exception cref="ArgumentException">Thrown when the name or habitat is empty or null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the weight is non-positive, the age is negative or the howling frequency is not within the range [0, 1].</exception>
    public Wolf(string name, double weight, int age, string habitat, double howlingFrequency = 0.9) : base(name, weight, age, habitat)
    {
        ValidateHowlingFrequency(howlingFrequency);

        HowlingFrequency = howlingFrequency;
    }

    /// <summary>
    /// Produces the characteristic sound of the wolf.
    /// </summary>
    public override void DoSound()
    {
        Console.WriteLine($"{Name} the wise wolf raises his snout and howls, 'Awoo-awoo!' under the moonlit sky.");
    }

    /// <summary>
    /// Provides statistics about the wolf.
    /// </summary>
    /// <returns>Statistics string.</returns>
    public override string Stats()
    {
        return $"{Name}'s howling frequency={HowlingFrequency}";
    }

    // Validation methods

    /// <summary>
    /// Validates the howling frequency of the wolf.
    /// </summary>
    /// <param name="howlingFrequency">The howling frequency to validate.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the howling frequency is not within the range [0, 1].</exception>
    private void ValidateHowlingFrequency(double howlingFrequency)
    {
        if (howlingFrequency < 0 || howlingFrequency > 1)
        {
            throw new ArgumentOutOfRangeException(nameof(howlingFrequency), "Howling frequency must be between 0 and 1.");
        }
    }
}
