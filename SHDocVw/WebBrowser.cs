using System.Runtime.InteropServices;

namespace SHDocVw;

[ComImport]
[CoClass(typeof(WebBrowserClass))]
[Guid("D30C1661-CDAF-11D0-8A3E-00C04FC9E26E")]
public interface WebBrowser : IWebBrowser2, DWebBrowserEvents2_Event
{
}
