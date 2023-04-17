using HelloWorldEnterpriseEdition.Interfaces;

namespace HelloWorldEnterpriseEdition.Implementation;

/// <summary>
/// FlexibleStringWriterProviderImplementationFactory implements IStringWriterProviderImplementationFactory
/// </summary>
internal class FlexibleStringWriterProviderImplementationFactory
    : IStringWriterProviderImplementationFactory
{
    /// <summary>
    /// Returns FlexibleStringWriterProviderImplementationFactory
    /// </summary>
    /// <returns>FlexibleStringWriterProviderImplementationFactory</returns>
    /// <exception cref="NotSupportedException">...</exception>
    public StringWriterProviderImplementation Create()
    {
        throw new NotSupportedException("Cannot instantiate FlexibleStringWriterProviderImplementation because reasons");
    }
}
