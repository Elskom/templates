using Elskom.Generic.Libs;

namespace Something;

/// <inheritdoc/>
public class CallbackPluginClass : ICallbackPlugin
{
    /// <inheritdoc/>
    public string PluginName
        => throw new NotImplementedException();

    /// <inheritdoc/>
    public bool SupportsSettings
        => throw new NotImplementedException();

    /// <inheritdoc/>
    public bool ShowModal
        => throw new NotImplementedException();

    /// <inheritdoc/>
    public object SettingsWindow
        => throw new NotImplementedException();

    /// <inheritdoc/>
    public void TestModsCallback()
        => throw new NotImplementedException();
}
