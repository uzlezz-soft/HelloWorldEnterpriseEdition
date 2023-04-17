namespace HelloWorldEnterpriseEdition.Implementation;

/// <summary>
/// Console string writer
/// Derives from text writer string writer
/// </summary>
internal class ConsoleStringWriter : TextWriterStringWriter
{
    /// <summary>
    /// Constructor
    /// </summary>
    public ConsoleStringWriter() : base(Console.Out) {}
}
