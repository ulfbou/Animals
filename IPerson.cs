namespace Animals;

/// <summary>
/// Defines behavior for a person.
/// </summary>
internal interface IPerson
{
    /// <summary>
    /// Allows the person to talk with a specified message.
    /// </summary>
    /// <param name="message">The message to be spoken by the person.</param>
    void Talk(string message);
}
