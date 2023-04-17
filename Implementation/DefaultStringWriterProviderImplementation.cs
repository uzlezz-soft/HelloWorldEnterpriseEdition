using HelloWorldEnterpriseEdition.Interfaces;

namespace HelloWorldEnterpriseEdition.Implementation;

/// <summary>
/// Default string writer provider implementation
/// </summary>
internal class DefaultStringWriterProviderImplementation : StringWriterProviderImplementation
{
    /// <summary>
    /// provider
    /// </summary>
    private IStringProvider _provider;
    /// <summary>
    /// writer
    /// </summary>
    private IStringWriter _writer;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="stringProvider">string provider</param>
    /// <param name="stringWriter">string writer</param>
    public DefaultStringWriterProviderImplementation(IStringProvider stringProvider, IStringWriter stringWriter)
        : base(stringProvider, stringWriter)
    {
        _provider = stringProvider;
        _writer = stringWriter;
    }

    /// <summary>
    /// Executes this implementation
    /// </summary>
    public override void Execute()
    {
        _writer.Write(_provider);
    }
}
