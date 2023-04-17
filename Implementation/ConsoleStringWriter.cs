namespace HelloWorldEnterpriseEdition.Implementation;

internal class ConsoleStringWriter : TextWriterStringWriter
{
    public ConsoleStringWriter() : base(Console.Out) {}
}
