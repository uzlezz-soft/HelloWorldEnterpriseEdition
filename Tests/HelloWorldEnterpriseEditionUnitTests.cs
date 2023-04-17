using HelloWorldEnterpriseEdition.Implementation;
using HelloWorldEnterpriseEdition.Interfaces;
using NUnit.Framework;

namespace HelloWorldEnterpriseEdition.Tests;

public class HelloWorldEnterpriseEditionUnitTests
{
    [Test]
    public void HelloWorldEnterpriseEditionStringProvider_ShouldReturnHelloWorld()
    {
        IStringProvider stringProvider = new HelloWorldStringProvider();

        Assert.AreEqual(stringProvider.Get(), "Hello World!");
    }
}
