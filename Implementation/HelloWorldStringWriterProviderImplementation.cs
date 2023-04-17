using HelloWorldEnterpriseEdition.Interfaces;

namespace HelloWorldEnterpriseEdition.Implementation;

/// <summary>
/// Hello world string writer provider implementation
/// </summary>
internal class HelloWorldStringWriterProviderImplementation 
    : FlexibleStringWriterProviderImplementation<HelloWorldStringProvider, ConsoleStringWriter>
{
}
