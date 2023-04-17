namespace HelloWorldEnterpriseEdition.Interfaces;

internal abstract class StringWriterProviderImplementation
{
    public StringWriterProviderImplementation(IStringProvider stringProvider, IStringWriter stringWriter) {}

    public abstract void Execute();
}