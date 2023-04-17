using HelloWorldEnterpriseEdition.Interfaces;

namespace HelloWorldEnterpriseEdition.Implementation;

/// <summary>
/// Default string provider
/// </summary>
internal class DefaultStringProvider : IStringProvider
{
    /// <summary>
    /// String
    /// </summary>
    protected string? String;

    /// <summary>
    /// Returns string
    /// </summary>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">In case of string being null</exception>
    public string Get()
    {
        if (String is null)
            throw new ArgumentNullException(nameof(String));

        return String;
    }
}
