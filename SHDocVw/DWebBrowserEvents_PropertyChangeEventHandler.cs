using System.Runtime.InteropServices;

namespace SHDocVw;

[TypeLibType(16)]
[ComVisible(false)]
public delegate void DWebBrowserEvents_PropertyChangeEventHandler([In][MarshalAs(UnmanagedType.BStr)] string Property);
