using System.Runtime.InteropServices;

namespace SHDocVw;

[TypeLibType(16)]
[ComVisible(false)]
public delegate void DWebBrowserEvents2_WebWorkerStartedEventHandler([In] uint dwUniqueID, [In][MarshalAs(UnmanagedType.BStr)] string bstrWorkerLabel);
