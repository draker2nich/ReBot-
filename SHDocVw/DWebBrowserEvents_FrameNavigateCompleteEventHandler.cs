using System.Runtime.InteropServices;

namespace SHDocVw;

[ComVisible(false)]
[TypeLibType(16)]
public delegate void DWebBrowserEvents_FrameNavigateCompleteEventHandler([In][MarshalAs(UnmanagedType.BStr)] string URL);
