using System.Runtime.InteropServices;

namespace SHDocVw;

[ComVisible(false)]
[TypeLibType(16)]
public delegate void DWebBrowserEvents2_ThirdPartyUrlBlockedEventHandler([In][MarshalAs(UnmanagedType.Struct)] ref object URL, [In] uint dwCount);
