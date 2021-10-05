using Elskom.Generic.Libs;

namespace Something;

/// <inheritdoc/>
public class EncryptionPluginClass : IEncryptionPlugin
{
    /// <inheritdoc/>
    public string PluginName
        => throw new NotImplementedException();

    /// <inheritdoc/>
    public void DecryptEntry(Stream input, string kOMFileName, uint algorithm)
        => throw new NotImplementedException();

    /// <inheritdoc/>
    public void EncryptEntry(Stream input, string kOMFileName, uint algorithm)
        => throw new NotImplementedException();
}
