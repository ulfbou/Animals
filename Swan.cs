namespace Animals;

/// <summary>
/// Represents a swan, a type of bird.
/// </summary>
internal class Swan : Bird
{
    private string mateBond;

    /// <summary>
    /// Gets or sets the mate bond of the swan.
    /// </summary>
    /// <exception cref="ArgumentException">Thrown when the mate bond is empty or null.</exception>
    public string MateBond
    {
        get => mateBond;
        internal set
        {
            ValidateMateBond(value);
            mateBond = value;
        }
    }

    /// <summary>
    /// Constructs a new instance of the Swan class.
    /// </summary>
    /// <param name="name">The name of the swan.</param>
    /// <param name="weight">The weight of the swan.</param>
    /// <param name="age">The age of the swan.</param>
    /// <param name="habitat">The habitat of the swan.</param>
    /// <param name="wingspan">The wingspan of the swan. Defaults to 15.</param>
    /// <param name="mateBond">The mate bond's name of the swan. Defaults to "Noone".</param>
    /// <exception cref="ArgumentException">Thrown when the name, habitat or mate bond is empty or null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the weight or wingspan is non-positive or the age is negative.</exception>
    public Swan(string name, double weight, int age, string habitat, double wingspan = 15, string mateBond = "Noone") : base(name, weight, age, habitat, wingspan)
    {
        ValidateMateBond(mateBond);

        MateBond = mateBond;
    }

    /// <summary>
    /// Produces the characteristic sound of the swan.
    /// </summary>
    public override void DoSound()
    {
        Console.WriteLine($"{Name} the graceful swan glides across the pond, her gentle honk echoing, 'Ah-honk, ah-honk!'");
    }

    /// <summary>
    /// Provides statistics about the swan.
    /// </summary>
    /// <returns>Statistics string.</returns>
    public override string Stats()
    {
        return $"{Name}'s mate bond is {MateBond}";
    }

    // Validation method

    /// <summary>
    /// Validates the mate bond of the swan.
    /// </summary> 
    /// <param name="mateBond">The mate bond to validate.</param>
    /// <exception cref="ArgumentException">Thrown when the mate bond is empty or null.</exception>
    private void ValidateMateBond(string mateBond)
    {
        if (string.IsNullOrWhiteSpace(mateBond))
        {
            throw new ArgumentException("Mate bond cannot be empty or null.", nameof(mateBond));
        }
    }
}
