namespace HelloWorldEnterpriseEdition.Interfaces;

/// <summary>
/// IStringWriterFactory
/// </summary>
internal interface IStringWriterFactory
{
    /// <summary>
    /// Returns new instance of IStringWriter
    /// </summary>
    /// <returns>IStringWriter</returns>
    public IStringWriter Create();
}
