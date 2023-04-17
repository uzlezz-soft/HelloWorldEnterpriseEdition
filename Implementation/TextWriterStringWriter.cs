using HelloWorldEnterpriseEdition.Interfaces;

namespace HelloWorldEnterpriseEdition.Implementation;

/// <summary>
/// Text writer string writer implementation
/// </summary>
internal class TextWriterStringWriter : IStringWriter
{
    /// <summary>
    /// Text writer
    /// </summary>
    private TextWriter _writer;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="writer">Text Writer</param>
    public TextWriterStringWriter(TextWriter writer) => _writer = writer;

    /// <summary>
    /// Writes string provided from string provider to stream
    /// </summary>
    /// <param name="stringProvider"></param>
    public void Write(IStringProvider stringProvider)
    {
        _writer.Write(stringProvider.Get());
    }
}
