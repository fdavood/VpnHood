﻿// ReSharper disable once RedundantNullableDirective
#nullable enable
using Android.OS;
using Android.Webkit;

namespace VpnHood.Client.App.Droid;

internal class AppWebChromeClient : WebChromeClient
{
    public override bool OnCreateWindow(WebView? view, bool isDialog, bool isUserGesture, Message? resultMsg)
    {
        if (view?.Context == null) return false;
        var newWebView = new WebView(view.Context);
        newWebView.SetWebViewClient(new AppWebViewClient());

        if (resultMsg?.Obj is not WebView.WebViewTransport transport) return false;
        transport.WebView = newWebView;
        resultMsg.SendToTarget();
        return true;
    }
}