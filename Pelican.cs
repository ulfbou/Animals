namespace Animals;

/// <summary>
/// Represents a pelican, a type of bird.
/// </summary>
internal class Pelican : Bird
{
    private double pouchSize;
    private double divingDepth;

    /// <summary>
    /// Gets or sets the size of the pelican's pouch.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the pouch size is non-positive.</exception>
    public double PouchSize
    {
        get => pouchSize;
        internal set
        {
            ValidatePouchSize(value);
            pouchSize = value;
        }
    }

    /// <summary>
    /// Gets or sets the diving depth of the pelican.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the diving depth is non-positive.</exception>
    public double DivingDepth
    {
        get => divingDepth;
        internal set
        {
            ValidateDivingDepth(value);
            divingDepth = value;
        }
    }

    /// <summary>
    /// Constructs a new instance of the Pelican class.
    /// </summary>
    /// <param name="name">The name of the pelican.</param>
    /// <param name="weight">The weight of the pelican.</param>
    /// <param name="age">The age of the pelican.</param>
    /// <param name="habitat">The habitat of the pelican.</param>
    /// <param name="wingspan">The wingspan of the pelican. Defaults to 17.</param>
    /// <param name="pouchSize">The size of the pelican's pouch. Defaults to 12.</param>
    /// <param name="divingDepth">The diving depth of the pelican. Defaults to 5.</param>
    /// <exception cref="ArgumentException">Thrown when the name or habitat is empty or null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the weight, wingspan, pouch size, or diving depth is non-positive or the age is negative.</exception>
    public Pelican(string name, double weight, int age, string habitat, double wingspan = 17, double pouchSize = 12, double divingDepth = 5) : base(name, weight, age, habitat, wingspan)
    {
        ValidatePouchSize(pouchSize);
        ValidateDivingDepth(divingDepth);

        PouchSize = pouchSize;
        DivingDepth = divingDepth;
    }

    /// <summary>
    /// Produces the characteristic sound of the pelican.
    /// </summary>
    public override void DoSound()
    {
        Console.WriteLine($"{Name} the eager pelican flaps his wings and squawks, ‘Swoosh-swoosh! Fish for lunch!’");
    }

    /// <summary>
    /// Provides statistics about the pelican.
    /// </summary>
    /// <returns>Statistics string.</returns>
    public override string Stats()
    {
        return $"{Name}'s Pouch Size={PouchSize} Diving depth={DivingDepth}";
    }

    // Validation methods

    /// <summary>
    /// Validates the size of the pelican's pouch.
    /// </summary>
    /// <param name="pouchSize">The pouch size to validate.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the pouch size is non-positive.</exception>
    private void ValidatePouchSize(double pouchSize)
    {
        if (pouchSize <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(pouchSize), "Pouch size must be positive.");
        }
    }

    /// <summary>
    /// Validates the diving depth of the pelican.
    /// </summary>
    /// <param name="divingDepth">The diving depth to validate.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the diving depth is non-positive.</exception>
    private void ValidateDivingDepth(double divingDepth)
    {
        if (divingDepth <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(divingDepth), "Diving depth must be positive.");
        }
    }
}
 