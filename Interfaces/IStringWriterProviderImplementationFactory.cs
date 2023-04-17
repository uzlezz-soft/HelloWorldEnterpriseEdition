namespace HelloWorldEnterpriseEdition.Interfaces;

/// <summary>
/// IStringWriterProviderImplementationFactory
/// </summary>
internal interface IStringWriterProviderImplementationFactory
{
    /// <summary>
    /// Returns new instance of StringWriterProviderImplementation
    /// </summary>
    /// <returns>StringWriterProviderImplementation</returns>
    public StringWriterProviderImplementation Create();
}
