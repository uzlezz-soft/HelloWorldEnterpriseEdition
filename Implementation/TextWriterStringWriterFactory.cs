using HelloWorldEnterpriseEdition.Interfaces;

namespace HelloWorldEnterpriseEdition.Implementation;

/// <summary>
/// TextWriterStringWriterFactory implements IStringWriterFactory
/// </summary>
internal class TextWriterStringWriterFactory : IStringWriterFactory
{
    /// <summary>
    /// Returns TextWriterStringWriter
    /// </summary>
    /// <returns>TextWriterStringWriter</returns>
    /// <exception cref="NotSupportedException">Just run this method and see it</exception>
    public IStringWriter Create()
    {
        throw new NotSupportedException("TextWriterStringWriter cannot be instantiated without supplying its constructor with text writer, which is not supported in factory");
    }
}
