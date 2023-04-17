using HelloWorldEnterpriseEdition.Interfaces;

namespace HelloWorldEnterpriseEdition.Implementation;

/// <summary>
/// ConsoleStringWriterFactory implements IStringWriterFactory
/// </summary>
internal class ConsoleStringWriterFactory : IStringWriterFactory
{
    /// <summary>
    /// Returns ConsoleStringWriter
    /// </summary>
    /// <returns>ConsoleStringWriter</returns>
    public IStringWriter Create()
    {
        return new ConsoleStringWriter();
    }
}
