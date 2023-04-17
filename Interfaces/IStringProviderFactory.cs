namespace HelloWorldEnterpriseEdition.Interfaces;

/// <summary>
/// IStringProviderFactory
/// </summary>
internal interface IStringProviderFactory
{
    /// <summary>
    /// Returns new IStringProvider instance
    /// </summary>
    /// <returns>IStringProvider</returns>
    public IStringProvider Create();
}
