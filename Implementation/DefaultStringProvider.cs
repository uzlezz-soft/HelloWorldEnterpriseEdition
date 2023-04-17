using HelloWorldEnterpriseEdition.Interfaces;

namespace HelloWorldEnterpriseEdition.Implementation;

internal class DefaultStringProvider : IStringProvider
{
    protected string? String;

    public string Get()
    {
        if (String is null)
            throw new ArgumentNullException(nameof(String));

        return String;
    }
}
