using Elskom.Generic.Libs;

namespace Something;

/// <inheritdoc/>
public class KomPluginClass : IKomPlugin
{
    /// <inheritdoc/>
    public string PluginName
        => throw new NotImplementedException();

    /// <inheritdoc/>
    public string KOMHeaderString
        => throw new NotImplementedException();

    /// <inheritdoc/>
    public int SupportedKOMVersion
        => throw new NotImplementedException();

    /// <inheritdoc/>
    public void Pack(string inpath, string outpath, string kOMFileName)
        => throw new NotImplementedException();

    /// <inheritdoc/>
    public void Unpack(string inpath, string outpath, string kOMFileName)
        => throw new NotImplementedException();

    /// <inheritdoc/>
    public void Delete(string inpath, bool folder)
        => throw new NotImplementedException();

    /// <inheritdoc/>
    public void ConvertCRC(int crcversion, string crcpath)
        => throw new NotImplementedException();

    /// <inheritdoc/>
    public void UpdateCRC(string crcpath, string checkpath)
        => throw new NotImplementedException();
}
