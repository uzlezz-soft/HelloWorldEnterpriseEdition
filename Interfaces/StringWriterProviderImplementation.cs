namespace HelloWorldEnterpriseEdition.Interfaces;

/*
 * StringWriterProviderImplementation abstract class
 */
internal abstract class StringWriterProviderImplementation
{
    public StringWriterProviderImplementation(IStringProvider stringProvider, IStringWriter stringWriter) {}

    /// <summary>
    /// Executes implementation
    /// </summary>
    public abstract void Execute();
}