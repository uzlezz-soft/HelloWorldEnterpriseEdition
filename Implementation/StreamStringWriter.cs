using HelloWorldEnterpriseEdition.Interfaces;

namespace HelloWorldEnterpriseEdition.Implementation;

internal class TextWriterStringWriter : IStringWriter
{
    private TextWriter _writer;

    public TextWriterStringWriter(TextWriter writer) => _writer = writer;

    public void Write(IStringProvider stringProvider)
    {
        _writer.Write(stringProvider.Get());
    }
}
