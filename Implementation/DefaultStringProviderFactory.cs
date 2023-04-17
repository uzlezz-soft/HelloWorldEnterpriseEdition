using HelloWorldEnterpriseEdition.Interfaces;

namespace HelloWorldEnterpriseEdition.Implementation;

/// <summary>
/// DefaultStringProviderFactory implements IStringProviderFactory interface
/// </summary>
internal class DefaultStringProviderFactory : IStringProviderFactory
{
    /// <summary>
    /// Returns DefaultStringProvider
    /// </summary>
    /// <returns>DefaultStringProvider</returns>
    public IStringProvider Create()
    {
        return new DefaultStringProvider();
    }
}
