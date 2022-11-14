using System;
using System.Linq;
using System.Threading.Tasks;
using ObjCRuntime;
using WebKit;
using Xamarin.Essentials;

namespace WebBox
{
    public class WebViewDelegate : WKNavigationDelegate
    {
        public WebViewDelegate()
        {
        }


        public override void DecidePolicy(WKWebView webView,
            WKNavigationAction navigationAction,
            Action<WKNavigationActionPolicy> decisionHandler)
        {
            var url = navigationAction.Request.Url.ToString();
            if (!Links.InternalLinks.Any(l => url.Contains(l)))
            {

                if (url.Contains("http"))
                {
                    try
                    {
                        var uri = new Uri(url);
                        Launcher.OpenAsync(uri);
                    }
                    catch (Exception)
                    {
                    }
                }
                decisionHandler(WKNavigationActionPolicy.Cancel);
            }
            else decisionHandler(WKNavigationActionPolicy.Allow);
        }
    }
}
