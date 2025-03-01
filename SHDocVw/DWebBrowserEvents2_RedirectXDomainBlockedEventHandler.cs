using System.Runtime.InteropServices;

namespace SHDocVw;

[TypeLibType(16)]
[ComVisible(false)]
public delegate void DWebBrowserEvents2_RedirectXDomainBlockedEventHandler([In][MarshalAs(UnmanagedType.IDispatch)] object pDisp, [In][MarshalAs(UnmanagedType.Struct)] ref object StartURL, [In][MarshalAs(UnmanagedType.Struct)] ref object RedirectURL, [In][MarshalAs(UnmanagedType.Struct)] ref object Frame, [In][MarshalAs(UnmanagedType.Struct)] ref object StatusCode);
