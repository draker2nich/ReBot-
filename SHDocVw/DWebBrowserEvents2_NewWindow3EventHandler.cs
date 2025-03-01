using System.Runtime.InteropServices;

namespace SHDocVw;

[ComVisible(false)]
[TypeLibType(16)]
public delegate void DWebBrowserEvents2_NewWindow3EventHandler([In][Out][MarshalAs(UnmanagedType.IDispatch)] ref object ppDisp, [In][Out] ref bool Cancel, [In] uint dwFlags, [In][MarshalAs(UnmanagedType.BStr)] string bstrUrlContext, [In][MarshalAs(UnmanagedType.BStr)] string bstrUrl);
