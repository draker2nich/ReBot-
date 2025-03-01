using System.Runtime.InteropServices;

namespace SHDocVw;

[ComVisible(false)]
[TypeLibType(16)]
public delegate void DWebBrowserEvents2_WindowStateChangedEventHandler([In] uint dwWindowStateFlags, [In] uint dwValidFlagsMask);
