// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace WebBox
{
    [Register("ViewController")]
    partial class ViewController
    {
        [Outlet]
        WebKit.WKWebView webView { get; set; }

        void ReleaseDesignerOutlets()
        {
            if (webView != null)
            {
                webView.Dispose();
                webView = null;
            }
        }
    }
}
