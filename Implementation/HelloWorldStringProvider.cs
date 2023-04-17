namespace HelloWorldEnterpriseEdition.Implementation;

/// <summary>
/// Hello world string provider implementation
/// Derives from default string provider
/// </summary>
internal class HelloWorldStringProvider : DefaultStringProvider
{
    /// <summary>
    /// Constructor
    /// </summary>
    public HelloWorldStringProvider()
    {
        String = "Hello World!";
    }
}