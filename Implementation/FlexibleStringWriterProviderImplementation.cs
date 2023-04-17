using HelloWorldEnterpriseEdition.Interfaces;

namespace HelloWorldEnterpriseEdition.Implementation;

internal class FlexibleStringWriterProviderImplementation<StringProvider, StringWriter>
    : DefaultStringWriterProviderImplementation
    where StringProvider : IStringProvider, new()
    where StringWriter : IStringWriter, new()
{
    public FlexibleStringWriterProviderImplementation() : base(new StringProvider(), new StringWriter())
    {
    }
}
