using System.Runtime.InteropServices;

namespace SHDocVw;

[TypeLibType(16)]
[ComVisible(false)]
public delegate void DWebBrowserEvents_NavigateCompleteEventHandler([In][MarshalAs(UnmanagedType.BStr)] string URL);
