using HelloWorldEnterpriseEdition.Interfaces;

namespace HelloWorldEnterpriseEdition.Implementation;

internal class DefaultStringWriterProviderImplementation : StringWriterProviderImplementation
{
    private IStringProvider _provider;
    private IStringWriter _writer;

    public DefaultStringWriterProviderImplementation(IStringProvider stringProvider, IStringWriter stringWriter)
        : base(stringProvider, stringWriter)
    {
        _provider = stringProvider;
        _writer = stringWriter;
    }

    public override void Execute()
    {
        _writer.Write(_provider);
    }
}
