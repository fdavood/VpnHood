﻿using System;
using VpnHood.Client.Device;
using VpnHood.Client.Device.WinDivert;

// ReSharper disable once CheckNamespace
namespace VpnHood.Client.App;

internal class VpnHoodAppProvider : IAppProvider
{
    public IDevice Device { get; } = new WinDivertDevice();
    public bool IsLogToConsoleSupported => true;
    public Uri? AdditionalUiUrl => WinApp.Instance.RegisterLocalDomain();
    public Uri UpdateInfoUrl => new ("https://github.com/vpnhood/VpnHood/releases/latest/download/VpnHoodClient-win-x64.json");
}