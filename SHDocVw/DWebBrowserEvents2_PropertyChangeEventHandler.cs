using System.Runtime.InteropServices;

namespace SHDocVw;

[ComVisible(false)]
[TypeLibType(16)]
public delegate void DWebBrowserEvents2_PropertyChangeEventHandler([In][MarshalAs(UnmanagedType.BStr)] string szProperty);
