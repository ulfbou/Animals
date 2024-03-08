namespace Animals
{
    /// <summary>
    /// Represents an abstract class for animals.
    /// </summary>
    internal abstract class Animal
    {
        // Private fields
        private string name;
        private double weight;
        private int age;
        private string habitat;

        /// <summary>
        /// Constructor for the Animal class.
        /// </summary>
        /// <param name="name">The name of the animal.</param>
        /// <param name="weight">The weight of the animal.</param>
        /// <param name="age">The age of the animal.</param>
        /// <param name="habitat">The habitat of the animal.</param>
        public Animal(string name, double weight, int age, string habitat)
        {
            // Validate input parameters (optional)
            ValidateName(name);
            ValidateWeight(weight);
            ValidateAge(age);
            ValidateHabitat(habitat);

            // Initialize instance variables
            this.name = name;
            this.weight = weight;
            this.age = age;
            this.habitat = habitat;
        }

        // Properties with getters and setters

        /// <summary>
        /// Gets or sets the name of the animal.
        /// </summary>
        public string Name
        {
            get => name;
            set
            {
                ValidateName(value);
                name = value;
            }
        }

        /// <summary>
        /// Gets or sets the weight of the animal.
        /// </summary>
        public double Weight
        {
            get => weight;
            set
            {
                ValidateWeight(value);
                weight = value;
            }
        }

        /// <summary>
        /// Gets or sets the age of the animal.
        /// </summary>
        public int Age
        {
            get => age;
            set
            {
                ValidateAge(value);
                age = value;
            }
        }

        /// <summary>
        /// Gets or sets the habitat of the animal.
        /// </summary>
        public string Habitat
        {
            get => habitat;
            set
            {
                ValidateHabitat(value);
                habitat = value;
            }
        }

        // Abstract method for making a sound

        /// <summary>
        /// Makes the animal produce its characteristic sound.
        /// </summary>
        public abstract void DoSound();

        // Abstract method for stats.

        /// <summary>
        /// Returns statistics about the animal.
        /// </summary>
        /// <returns>Statistics string.</returns>
        public abstract string Stats();

        // Validation methods

        /// <summary>
        /// Validates the name of the animal.
        /// </summary>
        /// <param name="name">The name to validate.</param>
        private void ValidateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be empty or null.", nameof(name));
            }
        }

        /// <summary>
        /// Validates the weight of the animal.
        /// </summary>
        /// <param name="weight">The weight to validate.</param>
        private void ValidateWeight(double weight)
        {
            if (weight <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(weight), "Weight must be positive.");
            }
        }

        /// <summary>
        /// Validates the age of the animal.
        /// </summary>
        /// <param name="age">The age to validate.</param>
        private void ValidateAge(int age)
        {
            if (age < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(age), "Age cannot be negative.");
            }
        }

        /// <summary>
        /// Validates the habitat of the animal.
        /// </summary>
        /// <param name="habitat">The habitat to validate.</param>
        private void ValidateHabitat(string habitat)
        {
            if (string.IsNullOrWhiteSpace(habitat))
            {
                throw new ArgumentException("Habitat cannot be empty or null.", nameof(habitat));
            }
        }
    }
}
