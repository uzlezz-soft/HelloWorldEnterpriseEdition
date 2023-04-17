using HelloWorldEnterpriseEdition.Interfaces;

namespace HelloWorldEnterpriseEdition.Implementation;

/// <summary>
/// HelloWorldStringProviderFactory implements IStringProviderFactory interface
/// </summary>
internal class HelloWorldStringProviderFactory : IStringProviderFactory
{
    /// <summary>
    /// Returns HelloWorldStringProvider
    /// </summary>
    /// <returns>HelloWorldStringProvider</returns>
    public IStringProvider Create()
    {
        return new HelloWorldStringProvider();
    }
}
