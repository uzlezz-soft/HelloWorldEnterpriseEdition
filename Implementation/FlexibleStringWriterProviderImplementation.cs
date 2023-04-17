using HelloWorldEnterpriseEdition.Interfaces;

namespace HelloWorldEnterpriseEdition.Implementation;

/// <summary>
/// Flexible string writer provider implementation
/// </summary>
/// <typeparam name="StringProvider">string provider</typeparam>
/// <typeparam name="StringWriter">string writer</typeparam>
internal class FlexibleStringWriterProviderImplementation<StringProvider, StringWriter>
    : DefaultStringWriterProviderImplementation
    where StringProvider : IStringProvider, new()
    where StringWriter : IStringWriter, new()
{
    /// <summary>
    /// Constructor
    /// </summary>
    public FlexibleStringWriterProviderImplementation() : base(new StringProvider(), new StringWriter())
    {
    }
}
