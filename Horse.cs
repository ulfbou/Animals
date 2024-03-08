namespace Animals;

/// <summary>
/// Represents a horse, a type of animal.
/// </summary>
internal class Horse : Animal
{
    private string breed;

    /// <summary>
    /// Gets or sets the breed of the horse.
    /// </summary>
    /// </summary>
    public string Breed
    {
        get => breed;
        internal set
        {
            ValidateBreed(value);
            breed = value;
        }
    }

    /// <summary>
    /// Constructs a new instance of the Horse class.
    /// </summary>
    /// <param name="name">The name of the horse.</param>
    /// <param name="weight">The weight of the horse.</param>
    /// <param name="age">The age of the horse.</param>
    /// <param name="habitat">The habitat of the horse.</param>
    /// <param name="breed">The breed of the horse. Defaults to "Arabian".</param>
    /// <exception cref="ArgumentException">Thrown when the name, habitat or breed is empty or null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the weight is non-positive or the age is negative.</exception>
    public Horse(string name, double weight, int age, string habitat, string breed = "Arabian") : base(name, weight, age, habitat)
    {
        ValidateBreed(breed);
        Breed = breed;
    }

    /// <summary>
    /// Produces the characteristic sound of the horse.
    public override void DoSound()
    {
        Console.WriteLine($"{Name} the galloping horse neighs, ‘Clip-clop, clip-clop!’—music to a rider’s ears.");
    }

    /// <summary>
    /// Provides statistics about the horse.
    /// </summary>
    /// <returns>Statistics string.</returns>
    public override string Stats()
    {
        return $"{Name}'s breed={Breed}";
    }

    // Validation method

    /// <summary>
    /// Validates the breed of the horse.
    /// </summary>
    /// <param name="breed">The breed to validate.</param>
    /// <exception cref="ArgumentException">Thrown when the breed is empty or null.</exception>
    private void ValidateBreed(string breed)
    {
        if (string.IsNullOrWhiteSpace(breed))
        {
            throw new ArgumentException("Breed cannot be empty or null.", nameof(breed));
        }
    }
}
