using BenchmarkDotNet.Attributes;
using HelloWorldEnterpriseEdition.Implementation;
using HelloWorldEnterpriseEdition.Interfaces;

namespace HelloWorldEnterpriseEdition.Tests;

public class HelloWorldEnterpriseEditionBenchmark
{
    [Benchmark]
    public void HelloWorldNaiveImplementation()
    {
        Console.WriteLine("Hello World!");
    }

    [Benchmark]
    public void HelloWorldEnterpriseImplementation()
    {
        StringWriterProviderImplementation implementation = new HelloWorldStringWriterProviderImplementation();
        implementation.Execute();
    }
}
