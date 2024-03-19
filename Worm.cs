namespace Animals;

/// <summary>
/// Represents a worm, a type of animal.
/// </summary>
internal class Worm : Animal
{
    private int segmentCount; 

    /// <summary>
    /// Gets or sets the number of segments of the worm.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the segment count is not positive.</exception>
    public int SegmentCount
    {
        get => segmentCount;
        internal set
        {
            ValidateSegmentCount(value);

            segmentCount = value;
        }
    }

    /// <summary>
    /// Constructs a new instance of the Worm class.
    /// </summary>
    /// <param name="name">The name of the worm.</param>
    /// <param name="weight">The weight of the worm.</param>
    /// <param name="age">The age of the worm.</param>
    /// <param name="habitat">The habitat of the worm.</param>
    /// <param name="segmentCount">The number of segments of the worm. Defaults to 10.</param>
    /// <exception cref="ArgumentException">Thrown when the name or habitat is empty or null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the weight or segment count is non-positive or the age is negative.</exception>
    public Worm(string name, double weight, int age, string habitat, int segmentCount = 10) : base(name, weight, age, habitat)
    {
        ValidateSegmentCount(segmentCount);

        SegmentCount = segmentCount;
    }

    /// <summary>
    /// Produces the characteristic sound of the worm.
    /// </summary>
    public override void DoSound()
    {
        Console.WriteLine($"{Name} the wiggly worm whispers, \"Squirm-squirm!\"");
    }

    /// <summary>
    /// Provides statistics about the worm.
    /// </summary>
    /// <returns>Statistics string.</returns>
    public override string Stats()
    {
        return $"{Name}'s segment count={SegmentCount}";
    }

    // Validation method

    /// <summary>
    /// Validates the segment count of the worm.
    /// </summary>
    /// <param name="segmentCount">The segment count to validate.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the segment count is not positive.</exception>
    private void ValidateSegmentCount(int segmentCount)
    {
        if (segmentCount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(segmentCount), "Segment count must be greater than 0.");
        }
    }
}