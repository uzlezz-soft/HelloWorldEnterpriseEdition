using HelloWorldEnterpriseEdition.Interfaces;

namespace HelloWorldEnterpriseEdition.Implementation;

/// <summary>
/// DefaultStringWriterProviderImplementationFactory implements IStringWriterProviderImplementationFactory
/// </summary>
internal class DefaultStringWriterProviderImplementationFactory
    : IStringWriterProviderImplementationFactory
{
    /// <summary>
    /// Returns StringWriterProviderImplementation
    /// </summary>
    /// <returns>StringWriterProviderImplementation</returns>
    /// <exception cref="NotSupportedException">...</exception>
    public StringWriterProviderImplementation Create()
    {
        throw new NotSupportedException("StringWriterProviderImplementation because reasons");
    }
}
