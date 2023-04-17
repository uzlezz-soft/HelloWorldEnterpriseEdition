namespace HelloWorldEnterpriseEdition.Interfaces;

/*
 * IStringWriter interface
 */
internal interface IStringWriter
{
    /// <summary>
    /// Writes the string from string provider
    /// </summary>
    /// <param name="stringProvider">string provider</param>
    public void Write(IStringProvider stringProvider);
}