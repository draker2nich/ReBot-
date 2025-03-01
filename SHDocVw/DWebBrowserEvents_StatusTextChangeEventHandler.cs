using System.Runtime.InteropServices;

namespace SHDocVw;

[ComVisible(false)]
[TypeLibType(16)]
public delegate void DWebBrowserEvents_StatusTextChangeEventHandler([In][MarshalAs(UnmanagedType.BStr)] string Text);
