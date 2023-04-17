using HelloWorldEnterpriseEdition.Interfaces;

namespace HelloWorldEnterpriseEdition.Implementation;

/// <summary>
/// HelloWorldStringWriterProviderImplementationFactory implements IStringWriterProviderImplementationFactory
/// </summary>
internal class HelloWorldStringWriterProviderImplementationFactory
    : IStringWriterProviderImplementationFactory
{
    /// <summary>
    /// Returns HelloWorldStringWriterProviderImplementation
    /// </summary>
    /// <returns>HelloWorldStringWriterProviderImplementation</returns>
    public StringWriterProviderImplementation Create()
    {
        return new HelloWorldStringWriterProviderImplementation();
    }
}
