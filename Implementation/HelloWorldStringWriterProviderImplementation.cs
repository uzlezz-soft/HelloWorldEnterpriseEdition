using HelloWorldEnterpriseEdition.Interfaces;

namespace HelloWorldEnterpriseEdition.Implementation;

internal class HelloWorldStringWriterProviderImplementation 
    : FlexibleStringWriterProviderImplementation<HelloWorldStringProvider, ConsoleStringWriter>
{
}
